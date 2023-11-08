using Microsoft.Maui.Graphics.Skia;

using SkiaSharp;
using SkiaSharp.Views.Maui;
using SkiaSharp.Views.Maui.Controls;

namespace OpenGLTest;

public partial class OGLWidget : SKGLView
{
    protected SKCanvas canvas;
    protected SKImageInfo info;
    protected SKRect drawRect;
    protected SKSurface surface;


    public OGLWidget() : base()
    {
    }

    protected override void OnPaintSurface(SKPaintGLSurfaceEventArgs args)
    {
        // call the base method
        base.OnPaintSurface(args);

        ICanvas icanvas = new SkiaCanvas() { Canvas = args.Surface.Canvas };
        icanvas.EnableDefaultShadow(1.0f);

        surface = args.Surface;
        //info = args.Info;
        drawRect = new SKRect(0, 0, info.Width, info.Height);

        canvas = surface.Canvas;

        // draw on the canvas

        canvas.Flush();
    }
}
