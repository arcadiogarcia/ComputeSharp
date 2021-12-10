using System;

#if WINDOWS_UWP
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ComputeSharp.Uwp;
#else
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace ComputeSharp.WinUI;
#endif

/// <summary>
/// Queues a certain number of parameterless frame requests
/// </summary>
public class EndlessFrameRequestsQueue : IFrameRequestsQueue
//public class EndlessFrameRequestsQueue : FrameworkElement, IFrameRequestsQueue
{
    ///// <summary>
    ///// Gets or sets whether or not the rendering is paused.
    ///// </summary>
    //public bool IsPaused
    //{
    //    get => (bool)GetValue(IsPausedProperty);
    //    set => SetValue(IsPausedProperty, value);
    //}

    ///// <summary>
    ///// The <see cref="DependencyProperty"/> backing <see cref="IsPaused"/>.
    ///// </summary>
    //public static readonly DependencyProperty IsPausedProperty = DependencyProperty.Register(
    //    nameof(IsPaused),
    //    typeof(bool),
    //    typeof(EndlessFrameRequestsQueue),
    //    new PropertyMetadata(false, OnIsPausedPropertyChanged));

    ///// <inheritdoc cref="DependencyPropertyChangedCallback"/>
    //private static void OnIsPausedPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    //{
    //    var @this = (EndlessFrameRequestsQueue)d;
    //    var isPaused = (bool)e.NewValue;

    //    if (!isPaused)
    //    {
    //        @this.FrameRequested?.Invoke(@this, EventArgs.Empty);
    //    }
    //}

    private bool isPaused;
    /// <summary>
    /// Gets or sets whether or not the rendering is paused.
    /// </summary>
    public bool IsPaused
    {
        get => isPaused;
        set
        {
            isPaused = value;
            if (!value)
            {
                FrameRequested?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    /// <inheritdoc/>
    public event EventHandler? FrameRequested;

    /// <inheritdoc/>
    public bool IsEmpty => IsPaused;

    /// <inheritdoc/>
    public bool TryDequeue(out object? frameProperties)
    {
        frameProperties = null;
        return !IsPaused;
    }

    /// <inheritdoc/>
    public void OnFrameStarted(object? frameParameters) { }
    /// <inheritdoc/>
    public void OnFrameEnded(object? frameParameters) { }
}
