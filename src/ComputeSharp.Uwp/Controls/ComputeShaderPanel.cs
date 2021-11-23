using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ComputeSharp.Uwp;

/// <summary>
/// A custom <see cref="SwapChainPanel"/> that can be used to render animated backgrounds.
/// It is powered by ComputeSharp and leverages compute shaders to create frames to display.
/// </summary>
public sealed unsafe partial class ComputeShaderPanel : SwapChainPanel
{
    /// <summary>
    /// Creates a new <see cref="ComputeShaderPanel"/> instance.
    /// </summary>
    public ComputeShaderPanel()
    {
        this.Loaded += ComputeShaderPanel_Loaded;
        this.Unloaded += ComputeShaderPanel_Unloaded;
        this.SizeChanged += ComputeShaderPanel_SizeChanged;
        this.CompositionScaleChanged += ComputeShaderPanel_CompositionScaleChanged;
    }

    /// <summary>
    /// Finalizes the current <see cref="ComputeShaderPanel"/> instance and releases all resources.
    /// </summary>
    ~ComputeShaderPanel()
    {
        OnDisposed();
    }

    // Initializes the swap chain and starts the render thread
    private void ComputeShaderPanel_Loaded(object sender, RoutedEventArgs e)
    {
        this.width = (float)ActualWidth;
        this.height = (float)ActualHeight;
        this.compositionScaleX = CompositionScaleX;
        this.compositionScaleY = CompositionScaleY;
        this.resolutionScale = (float)ResolutionScale;
        this.targetResolutionScale = 1.0f;
        //Remove this since it happens after owner of the control sets a value, instead set true default in property declaration
        //System.Diagnostics.Trace.WriteLine($"Enable dynamic resolution  prev value:isDynamicResolutionEnabled = {isDynamicResolutionEnabled}) ");
        //this.isDynamicResolutionEnabled = true;

        OnInitialize();
        //OnStartRenderLoop();
    }

    // Requests a cancellation for the render thread
    private void ComputeShaderPanel_Unloaded(object sender, RoutedEventArgs e)
    {
        OnStopRenderLoop();
    }

    // Updates the background store for the frame size factors used by the render thread
    private void ComputeShaderPanel_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        System.Diagnostics.Trace.WriteLine($"Panel size changed: {e.PreviousSize} to {e.NewSize}");
        if (e.PreviousSize == e.NewSize)
        {
            return;
        }

        this.width = (float)e.NewSize.Width;
        this.height = (float)e.NewSize.Height;

        OnResize();
    }

    // Updates the background store for the composition scale factors used by the render thread
    private void ComputeShaderPanel_CompositionScaleChanged(SwapChainPanel sender, object args)
    {
        System.Diagnostics.Trace.WriteLine($"Composition scale changed: {compositionScaleX} , {compositionScaleY} -> {CompositionScaleX}, {CompositionScaleY}");
        if (this.compositionScaleX == CompositionScaleX &&
            this.compositionScaleY == CompositionScaleY)
        {
            return;
        }

        this.compositionScaleX = CompositionScaleX;
        this.compositionScaleY = CompositionScaleY;

        OnResize();
    }
}