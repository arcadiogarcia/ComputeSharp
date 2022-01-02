using ComputeSharp.UI.Controls;
using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;

namespace ComputeSharp.SwapChain.Uwp.Views;

/// <summary>
/// A view for <see cref="Core.ViewModels.MainViewModel"/>.
/// </summary>
public sealed partial class MainView : UserControl
{
    public MainView()
    {
        this.InitializeComponent();

        var compositor = Window.Current.Compositor;
        var compositionBrush = new ComputeShaderCompositionBrush(100,100,5,compositor);
        compositionBrush.ColorAndPresentIn(1,0,0,1000000);

        var container = compositor.CreateContainerVisual();

        var colorVisual1 = compositor.CreateSpriteVisual();
        colorVisual1.Brush = compositor.CreateColorBrush(Colors.Blue);
        colorVisual1.Size = new System.Numerics.Vector2(50, 50);
        colorVisual1.Offset = new System.Numerics.Vector3(100, 100, 0);
        container.Children.InsertAtBottom(colorVisual1);

        var colorVisual2 = compositor.CreateSpriteVisual();
        colorVisual2.Brush = compositionBrush.Brush;
       colorVisual2.Size = new System.Numerics.Vector2(150, 150);
        colorVisual2.Offset = new System.Numerics.Vector3(100, 100, 0);
        container.Children.InsertAtBottom(colorVisual2);

        ElementCompositionPreview.SetElementChildVisual(this, container);
    }

    // Opens the shader selection panel
    private void OpenShaderSelectionPanelButton_Click(object sender, RoutedEventArgs e)
    {
        Root.Resources.Remove("ShaderSelectionPanel");
        Root.Children.Add(ShaderSelectionPanel);
    }

    // Hides the shader selection panel
    private void ShaderSelectionPanel_Tapped(object sender, TappedRoutedEventArgs e)
    {
        Root.Children.Remove(ShaderSelectionPanel);
    }

    // Updates the size of the shaders list panel
    private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        ShadersListContainerPanel.Height = Math.Round(e.NewSize.Height * 0.35);
    }
}
