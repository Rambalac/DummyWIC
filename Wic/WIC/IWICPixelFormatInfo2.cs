using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WIC
{
	[Guid("A9DB33A2-AF5F-43C7-B679-74F5984B5AA4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IWICPixelFormatInfo2 : IWICPixelFormatInfo
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetComponentType(out WICComponentType pType);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetCLSID(out Guid pclsid);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetSigningStatus(out uint pStatus);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetAuthor([In] uint cchAuthor, [In] [Out] ref ushort wzAuthor, out uint pcchActual);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetVendorGUID(out Guid pguidVendor);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetVersion([In] uint cchVersion, [In] [Out] ref ushort wzVersion, out uint pcchActual);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetSpecVersion([In] uint cchSpecVersion, [In] [Out] ref ushort wzSpecVersion, out uint pcchActual);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetFriendlyName([In] uint cchFriendlyName, [In] [Out] ref ushort wzFriendlyName, out uint pcchActual);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetFormatGUID(out Guid pFormat);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetColorContext([MarshalAs(UnmanagedType.Interface)] out IWICColorContext ppIColorContext);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetBitsPerPixel(out uint puiBitsPerPixel);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetChannelCount(out uint puiChannelCount);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetChannelMask([In] uint uiChannelIndex, [In] uint cbMaskBuffer, [In] [Out] ref byte pbMaskBuffer, out uint pcbActual);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void SupportsTransparency(out int pfSupportsTransparency);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetNumericRepresentation(out WICPixelFormatNumericRepresentation pNumericRepresentation);
	}
}
