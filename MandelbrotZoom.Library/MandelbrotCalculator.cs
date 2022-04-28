using ComputeSharp;
using MandelbrotZoom.Library.Shaders;
using System.ComponentModel;
using LanguageExt;

namespace MandelbrotZoom.Library;

public static class MandelbrotCalculator {
    public static EitherAsync<Win32Exception, IEnumerable<int>> CreateMandelbrotField(
        Settings settings
    )
        => Task.Run<Either<Win32Exception, IEnumerable<int>>>(() => {
            var (maxIterations, maxMagnitude, width, height, centerX, centerY, zoom, _) = settings;

            int[] array = Enumerable.Range(0, settings.Width * settings.Height).ToArray();
            using ReadWriteBuffer<int> buffer = Gpu.Default.AllocateReadWriteBuffer(array);
            Gpu.Default.For(
                buffer.Length,
                new MandelbrotCalculatorShader(
                    buffer,
                    maxIterations,
                    maxMagnitude,
                    width,
                    height,
                    centerX,
                    centerY,
                    zoom
                )
            );

            try {
                buffer.CopyTo(array);
            } catch (Win32Exception ex) {
                return ex;
            }

            return array;
        }).ToAsync();
}
