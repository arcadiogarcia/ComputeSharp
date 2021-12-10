using System;

#if WINDOWS_UWP

namespace ComputeSharp.Uwp;
#else

namespace ComputeSharp.WinUI;
#endif

/// <summary>
/// A queue that holds all the pending frame requests to be rendered
/// </summary>
public interface IFrameRequestsQueue
{
    /// <summary>
    /// Whether there are no more frame requests left in the queue
    /// </summary>
    bool IsEmpty { get; }

    /// <summary>
    /// Pops the next frame to be rendered from the queue
    /// </summary>
    public bool TryDequeue(out object? frameProperties);

    /// <summary>
    /// Will be called by the shader panel just before starting to render a frame
    /// </summary>
    public void OnFrameStarted(object? frameParameters);

    /// <summary>
    /// Will be called by the shader panel just after the frame is presented
    /// </summary>
    public void OnFrameEnded(object? frameParameters);

    /// <summary>
    /// Will be invoked whenever a frame render request is added to que queue
    /// </summary>
    public event EventHandler? FrameRequested;
}
