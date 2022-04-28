# MandelbrotZoom

With MandelbrotZoom, you can zoom into the Mandelbrot set. Uses DX12 Compute Shaders.

https://user-images.githubusercontent.com/100740726/165801737-86cfc958-9821-4de3-9590-e11cbc81f389.mp4

## Why do my graphics drivers crash when zooming?

Zooming into the Mandelbrot set is hard work for your GPU cores. The more iterations you set, the more work each of your GPU cores has to do. When your GPU is calculating a Mandelbrot set, it doesn't have the time to draw frames for Windows (the Operating System), meaning that Windows will automatically crash your graphics drivers (*because it thinks they are stuck*). To fix this issue, you could either set less iterations, or you could follow [this handy guide from Adobe](https://substance3d.adobe.com/documentation/spdoc/gpu-drivers-crash-with-long-computations-tdr-crash-128745489.html).

### Okay, why can't I use my CPU to zoom into the Mandelbrot set?

That would take ages - for each frame. Literally minutes. And there are hundreds of frames to be drawn, depending on the amount of iterations you set. This means that the zooming would take forever, perhaps even **days**. For each image, each pixel's color has to be separately determined by calculating it's "Mandelbrot set value". Each "Mandelbrot set value" calculation takes the amount of iterations you set in the program. Because the GPU has much, much more cores than the CPU, this means that each pixel's color can be determined much faster using the GPU.
