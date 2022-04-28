namespace MandelbrotZoom.Library;

public readonly record struct Settings(
    int MaxIterations,
    double MaxMagnitude,
    int Width,
    int Height,
    double CenterX,
    double CenterY,
    double Zoom,
    double ZoomFactor
);
