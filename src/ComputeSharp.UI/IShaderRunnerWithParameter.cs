﻿using System;

#if WINDOWS_UWP
namespace ComputeSharp.Uwp;
#else
namespace ComputeSharp.WinUI;
#endif

/// <summary>
/// An interface for a shader runner to be used with <see cref="ComputeShaderPanel"/>.
/// </summary>
public interface IShaderRunnerWithParameter
{
    /// <summary>
    /// Renders a single frame to a texture.
    /// </summary>
    /// <param name="texture">The target texture to render the frame to.</param>
    /// <param name="timespan">The timespan for the current frame.</param>
    /// <param name="frameParameters">The parameters of the frame.</param>
    public void Execute(IReadWriteTexture2D<Float4> texture, TimeSpan timespan, object? frameParameters);
}
