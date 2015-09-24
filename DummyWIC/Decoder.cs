using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using WIC;

namespace DummyWIC
{
    [Guid("CACAF262-9370-4615-A13B-9F5539DA4C0A")]
    [ComImport]
    class WICImagingFactory { }

    [ComVisible(true)]
    [Guid("DD48659C-F21F-4C15-AE70-6879ED43B84C")]
    public class Decoder : IWICBitmapDecoder
    {
        public void CopyPalette([In, MarshalAs(UnmanagedType.Interface)] IWICPalette pIPalette)
        {
            throw new COMException("No Palette", (int)WinCodecErrors.WINCODEC_ERR_PALETTEUNAVAILABLE);
        }

        public void GetColorContexts([In] uint cCount, [In, MarshalAs(UnmanagedType.Interface), Out] ref IWICColorContext ppIColorContexts, out uint pcActualCount)
        {
            pcActualCount = 0;
        }

        public void GetContainerFormat(out Guid pguidContainerFormat)
        {
            pguidContainerFormat = new Guid("BBE1100D-3781-4FCC-BF0D-46FBAAECC01F");
        }

        public void GetDecoderInfo([MarshalAs(UnmanagedType.Interface)] out IWICBitmapDecoderInfo ppIDecoderInfo)
        {
            var imagingFactory = (IWICImagingFactory)new WICImagingFactory();
            IWICComponentInfo componentInfo;
            var guid = GetType().GUID;
            imagingFactory.CreateComponentInfo(ref guid, out componentInfo);
            ppIDecoderInfo = (IWICBitmapDecoderInfo)componentInfo;
        }

        public void GetFrame([In] uint index, [MarshalAs(UnmanagedType.Interface)] out IWICBitmapFrameDecode ppIBitmapFrame)
        {
            ppIBitmapFrame = new Frame();
        }

        public void GetFrameCount(out uint pCount)
        {
            pCount = 1;
        }

        public void GetMetadataQueryReader([MarshalAs(UnmanagedType.Interface)] out IWICMetadataQueryReader ppIMetadataQueryReader)
        {
            throw new COMException("Not Supported", (int)WinCodecErrors.WINCODEC_ERR_UNSUPPORTEDOPERATION);
        }

        public void GetPreview([MarshalAs(UnmanagedType.Interface)] out IWICBitmapSource ppIBitmapSource)
        {
            ppIBitmapSource = new Frame();
        }

        public void GetThumbnail([MarshalAs(UnmanagedType.Interface)] out IWICBitmapSource ppIThumbnail)
        {
            ppIThumbnail = new Frame();
        }

        public void Initialize([In, MarshalAs(UnmanagedType.Interface)] IStream pIStream, [In] WICDecodeOptions cacheOptions)
        {

        }

        public void QueryCapability([In, MarshalAs(UnmanagedType.Interface)] IStream pIStream, out uint pdwCapability)
        {
            pdwCapability = (uint)(WICBitmapDecoderCapabilities.WICBitmapDecoderCapabilityCanDecodeThumbnail
                    | WICBitmapDecoderCapabilities.WICBitmapDecoderCapabilityCanDecodeAllImages
                    | WICBitmapDecoderCapabilities.WICBitmapDecoderCapabilityCanDecodeThumbnail);
        }
    }
}
