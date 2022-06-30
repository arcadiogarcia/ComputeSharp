using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using CommunityToolkit.Diagnostics;
using ComputeSharp.Graphics.Helpers;
using TerraFX.Interop.DirectX;
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
        // This forward branch is predicted taken by the JIT, and when tier-1 JIT kicks in
        // it will just be removed if the IsDebugOutputEnabled flag is not set. The resulting
        // single branch can then be inlined without bloating the code size in the caller.
        if (!Configuration.IsDebugOutputEnabled)
        {
            if (result < 0)
            {
                ThrowHelper.ThrowWin32Exception(result);
            }
        }
        else
        {
            // Move the extended debug logic into a non inlineable method to help the inliner in the standard case
            [MethodImpl(MethodImplOptions.NoInlining)]
            static void AssertWithDebugInfo(int result)
            {
                var errorsOrWarnings = DeviceHelper.FlushAllID3D12InfoQueueMessagesAndCheckForErrorsOrWarnings();

                if (result < 0)
                {
                    ThrowHelper.ThrowWin32Exception(result);
                }

                var unhandledMessages = errorsOrWarnings.Where(x => !DeviceHelper.TryHandleMessage(x.Item1, x.Item2)).ToArray();

                if (unhandledMessages.Length > 0)
                {
                    ThrowHelper.ThrowWin32Exception("Warning or error detected by ID3D12InfoQueue.");
                }
            }

            AssertWithDebugInfo(result);
        }
    }
}
