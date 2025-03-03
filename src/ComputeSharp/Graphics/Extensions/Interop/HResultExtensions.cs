﻿using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
#if DEBUG
using ComputeSharp.Graphics.Helpers;
#endif
using Microsoft.Toolkit.Diagnostics;
using TerraFX.Interop.Windows;

namespace ComputeSharp.Core.Extensions;

/// <summary>
/// Helper methods to efficiently throw exceptions.
/// </summary>
[DebuggerStepThrough]
internal static class HResultExtensions
{
    /// <summary>
    /// Throws a <see cref="Win32Exception"/> if <paramref name="result"/> represents an error.
    /// </summary>
    /// <param name="result">The input <see cref="HRESULT"/> to check.</param>
    /// <exception cref="Win32Exception">Thrown if <paramref name="result"/> represents an error.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Assert(this HRESULT result)
    {
        Assert((int)result);
    }

    /// <summary>
    /// Throws a <see cref="Win32Exception"/> if <paramref name="result"/> represents an error.
    /// </summary>
    /// <param name="result">The input <see cref="int"/> to check.</param>
    /// <exception cref="Win32Exception">Thrown if <paramref name="result"/> represents an error.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Assert(this int result)
    {
#if DEBUG
        bool hasErrorsOrWarnings = DeviceHelper.FlushAllID3D12InfoQueueMessagesAndCheckForErrorsOrWarnings();

        if (result < 0)
        {
            ThrowHelper.ThrowWin32Exception(result);
        }

        if (hasErrorsOrWarnings)
        {
            ThrowHelper.ThrowWin32Exception("Warning or error detected by ID3D12InfoQueue");
        }
#else
        if (result < 0)
        {
            ThrowHelper.ThrowWin32Exception(result);
        }
#endif
    }
}
