using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WIC;

namespace DummyWIC
{
    [ComVisible(true)]
    class Frame : IWICBitmapFrameDecode
    {
        public void CopyPalette([In, MarshalAs(UnmanagedType.Interface)] IWICPalette pIPalette)
        {
            throw new COMException("No Palette", (int)WinCodecErrors.WINCODEC_ERR_PALETTEUNAVAILABLE);
        }

        public void CopyPixels([In] ref WICRect prc, [In] uint cbStride, [In] uint cbBufferSize, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 2), Out] byte[] pbBuffer)
        {

        }

        public void GetColorContexts([In] uint cCount, [In, MarshalAs(UnmanagedType.Interface), Out] ref IWICColorContext ppIColorContexts, out uint pcActualCount)
        {
            pcActualCount = 0;
        }

        public void GetMetadataQueryReader([MarshalAs(UnmanagedType.Interface)] out IWICMetadataQueryReader ppIMetadataQueryReader)
        {
            throw new COMException("Not Supported", (int)WinCodecErrors.WINCODEC_ERR_UNSUPPORTEDOPERATION);
        }

        public void GetPixelFormat(out Guid pPixelFormat)
        {
            pPixelFormat = new Guid("6FDDC324-4E03-4BFE-B185-3D77768DC90F");
        }

        public void GetResolution(out double pDpiX, out double pDpiY)
        {
            pDpiX = 96;
            pDpiY = 96;
        }

        public void GetSize(out uint puiWidth, out uint puiHeight)
        {
            puiWidth = 3000;
            puiHeight = 2000;
        }

        public void GetThumbnail([MarshalAs(UnmanagedType.Interface)] out IWICBitmapSource ppIThumbnail)
        {
            throw new COMException("Not Supported", (int)WinCodecErrors.WINCODEC_ERR_CODECNOTHUMBNAIL);
        }
    }
}
