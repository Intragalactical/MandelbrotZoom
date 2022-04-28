using ComputeSharp;

namespace MandelbrotZoom.Library.Shaders;

[AutoConstructor]
public readonly partial struct MandelbrotCalculatorShader : IComputeShader {
    private const int FullRGB = 0xffffff;

    public readonly ReadWriteBuffer<int> buffer;
    public readonly int maxIterations;
    public readonly double maxMagnitude;
    public readonly int width;
    public readonly int height;
    public readonly double centerX;
    public readonly double centerY;
    public readonly double zoom;

    private double Calculate(double x, double y) {
        double cReal = x;
        double cImaginary = y;
        double zReal = 0D;
        double zImaginary = 0D;
        double oldzReal;

        int iteration = 0;

        do {
            oldzReal = zReal;

            // z = z * z
            zReal = (zReal * zReal) - (zImaginary * zImaginary);
            zImaginary = (oldzReal * zImaginary) + (zImaginary * oldzReal);

            // z += c
            zReal += cReal;
            zImaginary += cImaginary;

            iteration++;
        } while (((zReal * zReal) + (zImaginary * zImaginary)) <= maxMagnitude && iteration < maxIterations);

        return iteration / (double)maxIterations;
    }

    private static int Invert(int color)
        => color ^ FullRGB;

    private static int CalculateColor(double mandelbrot)
        => Invert((int)(FullRGB * mandelbrot));

    public void Execute() {
        int x = ThreadIds.X % width;
        int y = ThreadIds.X / width;
        double minX = centerX - (zoom / 2D);
        double minY = centerY - (zoom / 2D);
        double realX = minX + (x / (double)width * zoom);
        double realY = minY + (y / (double)height * zoom);
        buffer[ThreadIds.X] = CalculateColor(Calculate(realX, realY));
    }
}
