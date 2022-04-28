using ComputeSharp;
using LanguageExt;
using MandelbrotZoom.Library;
using System.ComponentModel;
using System.Drawing.Imaging;

namespace MandelbrotZoom;

public partial class MainForm : Form {
    private const double StartingZoom = 4.8D;
    private const double MaxMagnitude = 4.0D;

    private CancellationTokenSource CancellationTokenSource { get; set; }

    public MainForm() {
        InitializeComponent();

        CancellationTokenSource = new();
    }
    private static Task<Bitmap> GenerateMandelbrotBitmapFromField(
        IEnumerable<int> mandelbrotFieldTask,
        int width,
        int height
    ) => Task.Run(() => {
        int[] mandelbrotField = mandelbrotFieldTask.ToArray();
        Bitmap bmp = new(width, height, PixelFormat.Format24bppRgb);
        BitmapData locked = bmp.LockBits(
            new(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite,
            bmp.PixelFormat
        );

        int bytesPerPixel = Image.GetPixelFormatSize(locked.PixelFormat) / 8;
        int heightInPixels = locked.Height;

        unsafe {
            byte* firstPixelPtr = (byte*)locked.Scan0;

            _ = Parallel.For(0, heightInPixels, y => {
                byte* currentLine = firstPixelPtr + (y * locked.Stride);
                for (int x = 0; x < width; x++) {
                    int xInBytes = x * bytesPerPixel;
                    Color a = Color.FromArgb(mandelbrotField[(y * width) + x]);
                    currentLine[xInBytes] = a.B;
                    currentLine[xInBytes + 1] = a.G;
                    currentLine[xInBytes + 2] = a.R;
                }
            });
        }

        bmp.UnlockBits(locked);

        return bmp;
    });

    private static async Task<Either<Win32Exception, Bitmap>> GenerateMandelbrotBitmap(Settings settings) {
        Either<Win32Exception, IEnumerable<int>> mandelbrotFieldOrException = await MandelbrotCalculator.CreateMandelbrotField(settings);
        Either<Win32Exception, Bitmap> mandelbrotImage = await mandelbrotFieldOrException
            .MatchAsync<Either<Win32Exception, Bitmap>>(
                async mandelbrotField =>
                    await GenerateMandelbrotBitmapFromField(
                        mandelbrotField,
                        settings.Width,
                        settings.Height
                    ),
                left => left
            );
        return mandelbrotImage;
    }

    private void SetControlsEnabled(bool enabled) {
        ZoomStepNUD.Enabled = enabled;
        WidthNUD.Enabled = enabled;
        HeightNUD.Enabled = enabled;
        CenterXNUD.Enabled = enabled;
        CenterYNUD.Enabled = enabled;
        MaxIterationsNUD.Enabled = enabled;
        PreviewButton.Enabled = enabled;
        PreviewWithZoomButton.Enabled = enabled;
        GenerateButton.Enabled = enabled;
    }

    private void ZoomInPreview(Settings settings) {
        new Thread(async () => {
            Settings newSettings = settings;
            while (!CancellationTokenSource.IsCancellationRequested) {
                Either<Win32Exception, Bitmap> newBitmapOrException = await GenerateMandelbrotBitmap(newSettings);
                _ = newBitmapOrException.Match(
                    bitmap => {
                        _ = MandelbrotPicture.Invoke(new MethodInvoker(() => MandelbrotPicture.BackgroundImage = bitmap));
                        newSettings = newSettings with { Zoom = newSettings.Zoom - (newSettings.Zoom / newSettings.ZoomFactor) };
                    },
                    exception => MessageBox.Show(exception.Message + "\n" + exception.StackTrace, "Win32Exception has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                );
            }

            Invoke(() => SetControlsEnabled(true));
        }) { IsBackground = true }.Start();
    }

    private void MainForm_Load(object sender, EventArgs e) {
    }

    private async void PreviewButton_Click(object sender, EventArgs e) {
        Settings settings = new(
            (int)MaxIterationsNUD.Value,
            MaxMagnitude,
            (int)WidthNUD.Value,
            (int)HeightNUD.Value,
            (double)CenterXNUD.Value,
            (double)CenterYNUD.Value,
            StartingZoom,
            (double)ZoomStepNUD.Value
        );
        Either<Win32Exception, Bitmap> mandelbrotMapOrException = await GenerateMandelbrotBitmap(settings);
        _ = mandelbrotMapOrException.Match(
            bitmap => MandelbrotPicture.BackgroundImage = bitmap,
            exception => MessageBox.Show(exception.Message + "\n" + exception.StackTrace, "Win32Exception has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        );
    }

    private void PreviewWithZoomButton_Click(object sender, EventArgs e) {
        if (PreviewWithZoomButton.Text == "Preview with Zoom") {
            CancellationTokenSource = new();
            SetControlsEnabled(false);
            PreviewWithZoomButton.Enabled = true;
            PreviewWithZoomButton.Text = "Stop Preview";
            Settings settings = new(
                (int)MaxIterationsNUD.Value,
                MaxMagnitude,
                (int)WidthNUD.Value,
                (int)HeightNUD.Value,
                (double)CenterXNUD.Value,
                (double)CenterYNUD.Value,
                StartingZoom,
                (double)ZoomStepNUD.Value
            );
            ZoomInPreview(settings);
        } else {
            PreviewWithZoomButton.Text = "Preview with Zoom";
            CancellationTokenSource.Cancel();
        }
    }
}
