using ComputeSharp.Core.Extensions;
using ComputeSharp.Interop;
using System;
using System.Collections.Generic;
using System.Text;

using Windows.UI.Composition;


using Windows.Win32;
//using static Windows.Win32.Constants;
using Windows.Win32.Graphics;
using Windows.Win32.Graphics.CompositionSwapchain;
using Windows.Win32.Graphics.Direct3D;
using Windows.Win32.Graphics.Direct3D11;
using System.Runtime.InteropServices;
using Windows.Win32.System.WinRT.Composition;
using Windows.Win32.Graphics.Dxgi;

namespace ComputeSharp.UI.Controls
{
    /// <summary>
    /// TODO
    /// </summary>
    public class ComputeShaderCompositionBrush
    {
        private ID3D11Device _device;
        private Compositor _compositor;
        private IPresentationManager _manager;
        private IPresentationSurface _surface;


        private List<IPresentationBuffer> _buffers = new();
        private List<ID3D11Texture2D> _textures = new();
        private List<Windows.Win32.Foundation.HANDLE> _bufferAvailableEvents = new();

        /// <summary>
        /// TODO
        /// </summary>
        public CompositionSurfaceBrush Brush { get; private set; }

        /// <summary>
        /// TODO
        /// </summary>
        public unsafe ComputeShaderCompositionBrush(uint width, uint height, int bufferCount, Compositor compositor)
        {
            _compositor = compositor;


            //Based on https://docs.microsoft.com/en-us/windows/win32/comp_swapchain/comp-swapchain-examples#example-17using-an-abstraction-layer-to-present-using-either-the-new-composition-swapchain-api-or-dxgi-from-your-application
            var deviceCreatingFlags =
               D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_BGRA_SUPPORT |
               D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_SINGLETHREADED |
               D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_PREVENT_INTERNAL_THREADING_OPTIMIZATIONS;

            uint D3D11_SDK_VERSION = 0x7;

            //Windows.Win32.c

            PInvoke.D3D11CreateDevice(
                null,
                D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_HARDWARE,
                 default(Windows.Win32.Foundation.HINSTANCE),
                deviceCreatingFlags,
                null,
                0,
               D3D11_SDK_VERSION,
               out var device,
               null,
               out var deviceContext).ThrowOnFailure();

            _device = device;

            PInvoke.CreatePresentationFactory(device, GuidOf<IPresentationFactory>(), out var pFactory).ThrowOnFailure();

            var factory = Marshal.GetObjectForIUnknown((IntPtr)pFactory) as IPresentationFactory;

            if (factory is null || factory.IsPresentationSupported() == 0)
            {
                throw new NotImplementedException();
            }

            var manager = factory.CreatePresentationManager();
            _manager = manager;

            uint COMPOSITIONSURFACE_ALL_ACCESS = 0x0003;

            PInvoke.DCompositionCreateSurfaceHandle(COMPOSITIONSURFACE_ALL_ACCESS, null, out var compositionSurfaceHandle).ThrowOnFailure();

            _surface = manager.CreatePresentationSurface(compositionSurfaceHandle);

            var compositorInterop = (ICompositorInterop)Marshal.GetObjectForIUnknown(Marshal.GetComInterfaceForObject(_compositor, typeof(ICompositorInterop)));
            compositorInterop.CreateCompositionSurfaceForHandle(compositionSurfaceHandle, out var compositionSurface);

            var surfaceBrush = _compositor.CreateSurfaceBrush();
            surfaceBrush.Surface = compositionSurface;

            Brush = surfaceBrush;


            for (var i = 0; i < bufferCount; i++)
            {
                MakeTexture(width, height, out var buffer, out var texture);

                _buffers.Add(buffer);
                _textures.Add(texture);

                _bufferAvailableEvents.Add(buffer.GetAvailableEvent());
            }
        }

        private unsafe void MakeTexture(uint width, uint height, out IPresentationBuffer buffer, out ID3D11Texture2D texture)
        {
            {
                var t = GraphicsDevice.Default.AllocateReadWriteTexture2D<Rgba32, Float4>((int)width, (int)height);
                var r = t.D3D12Resource;
                var resourceObject = Marshal.GetObjectForIUnknown((IntPtr)r);
                buffer = _manager.AddBufferFromResource(resourceObject);
            }


            D3D11_TEXTURE2D_DESC desc;
            desc.Width = width;
            desc.Height = height;
            desc.MipLevels = 1;
            desc.ArraySize = 1;
            desc.Format = Windows.Win32.Graphics.Dxgi.Common.DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM;
            desc.SampleDesc.Count = 1;
            desc.SampleDesc.Quality = 0;
            desc.Usage = D3D11_USAGE.D3D11_USAGE_DEFAULT;
            desc.BindFlags = D3D11_BIND_FLAG.D3D11_BIND_SHADER_RESOURCE | D3D11_BIND_FLAG.D3D11_BIND_RENDER_TARGET;
            desc.MiscFlags = D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_SHARED | D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_SHARED_NTHANDLE | D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_SHARED_DISPLAYABLE;
            desc.CPUAccessFlags = 0;

            _device.CreateTexture2D(desc, null, out texture);
            var resource = (IDXGIResource1)texture;

            uint GENERIC_ALL = 0x10000000;
            resource.CreateSharedHandle(null, GENERIC_ALL, null, out var bufferHandle);

            buffer = _manager.AddBufferFromResource(resource);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal ID3D11Texture2D GetBackBuffer()
        {
            var waitIndex = PInvoke.WaitForMultipleObjects(new ReadOnlySpan<Windows.Win32.Foundation.HANDLE>(_bufferAvailableEvents.ToArray()), false, uint.MaxValue);
            var WAIT_OBJECT_0 = 0; //Per https://docs.microsoft.com/en-us/windows/win32/api/synchapi/nf-synchapi-waitformultipleobjects
            var bufferIndex = (int)(waitIndex - WAIT_OBJECT_0);

            _surface.SetBuffer(_buffers[bufferIndex]);

            return _textures[bufferIndex];
        }

        internal void Present(SystemInterruptTime targetTime)
        {
            _manager.SetTargetTime(targetTime);
            _manager.Present();
        }


        /// <summary>
        /// TODO
        /// </summary>
        public void ColorAndPresentIn(float r, float g, float b, ulong ticks)
        {
            PInvoke.QueryInterruptTimePrecise(out var preciseTime);
            SystemInterruptTime presentTime = new SystemInterruptTime() { value = preciseTime + ticks };

            var backbuffer = GetBackBuffer();
            Fill(backbuffer, r, g, b);
            Present(presentTime);
        }

        /// <summary>
        /// TODO
        /// </summary>
        internal unsafe void Fill(ID3D11Texture2D texture, float r, float g, float b)
        {
            _device.GetImmediateContext(out var context);

            _device.CreateRenderTargetView(texture, null, out var view);

            context.ClearRenderTargetView(view, 1f);
        }

        private static Guid GuidOf<T>() =>
             Guid.Parse(((GuidAttribute)typeof(T).GetCustomAttributes(typeof(GuidAttribute), false)[0]).Value);
    }
}
