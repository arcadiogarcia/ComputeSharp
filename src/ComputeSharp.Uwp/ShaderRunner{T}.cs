using System;

namespace ComputeSharp.Uwp;

/// <summary>
/// An <see cref="IShaderRunner"/> implementation powered by a supplied shader type.
/// </summary>
/// <typeparam name="T">The type of shader to use to render frames.</typeparam>
/// <typeparam name="TParameters">The type of shader to use to render frames.</typeparam>
public sealed class ShaderRunner<T, TParameters> : IShaderRunner
    where T : struct, IPixelShader<Float4>
    where TParameters : struct
{
    /// <summary>
    /// The <see cref="Func{T1, TResult}"/> instance used to create shaders to run.
    /// </summary>
    private readonly Func<TimeSpan, TParameters, T> shaderFactory;

    /// <summary>
    /// Creates a new <see /> instance that will create shader instances with
    /// the default constructor. Only use this constructor if the shader doesn't require any additional
    /// resources or other parameters being initialized before being dispatched on the GPU.
    /// </summary>
    public ShaderRunner()
    {
        this.shaderFactory = static (_, _) => default;
    }

    /// <summary>
    /// Creates a new <see /> instance.
    /// </summary>
    /// <param name="shaderFactory">The <see cref="Func{T1, T2, TResult}"/> instance used to create shaders to run.</param>
    public ShaderRunner(Func<TimeSpan, TParameters, T> shaderFactory)
    {
        this.shaderFactory = shaderFactory;
    }

    /// <inheritdoc/>
    public void Execute(IReadWriteTexture2D<Float4> texture, TimeSpan time, object parameters)
    {
        Gpu.Default.ForEach(texture, this.shaderFactory(time, (TParameters)parameters));
    }
}