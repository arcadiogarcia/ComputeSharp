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
public class FrameRequestsQueue : IFrameRequestsQueue
{
    private volatile int PendingFrames = 0;

    /// <inheritdoc/>
    public event EventHandler? FrameRequested;

    /// <inheritdoc/>
    public bool IsEmpty => PendingFrames > 0;

    /// <inheritdoc/>
    public void RequestFrame()
    {
        PendingFrames++;
        FrameRequested?.Invoke(this, EventArgs.Empty);
    }

    /// <inheritdoc/>
    public bool TryDequeue(out object? frameProperties)
    {
        frameProperties = null;
        if (PendingFrames <= 0)
        {
            return false;
        }
        PendingFrames--;
        return true;
    }

    /// <inheritdoc/>
    public void OnFrameStarted(object? frameParameters) { }
    /// <inheritdoc/>
    public void OnFrameEnded(object? frameParameters) { }
}
