using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Plugin.Maui.Yandex.Ads.iOS
{
	[Native]
	public enum YMAAdErrorCode : ulong
	{
		EmptyBlockID,
		InvalidBannerSize,
		InvalidUUID,
		NoSuchBlockID,
		NoFill,
		BadServerResponse,
		BannerSizeMismatch,
		AdTypeMismatch,
		ServiceTemporarilyNotAvailable,
		InterstitialHasAlreadyBeenPresented,
		InterstitialOrientationMismatch,
		MetricaNotStarted
	}

	[Native]
	public enum YMANativeErrorCode : ulong
	{
		NoViewForAsset,
		InvalidViewForBinding,
		InvalidBinder,
		AdTypeMismatch
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct YMAHorizontalOffset
	{
		public nfloat left;

		public nfloat right;
	}

	[Native]
	public enum YMASizeConstraintType : long
	{
		Fixed,
		FixedBannerRatio,
		PreferredBannerRatio
	}

	[Native]
	public enum YMABlockType : ulong
	{
		Unknown,
		Preroll,
		Midroll,
		Postroll,
		Pauseroll,
		Overlayroll
	}

	[Native]
	public enum YMAVASTAdType : ulong
	{
		Unknown,
		InLine,
		Wrapper
	}

	[Native]
	public enum YMADeliveryMethod : ulong
	{
		Unknown,
		Streaming,
		Progressive
	}

	[Native]
	public enum YMAVASTErrorCode : ulong
	{
		NoAdsInVASTResponse,
		InvalidXMLResponse,
		CannotBuildRequest
	}

	[Native]
	public enum YMAIconResourceType : ulong
	{
		Unknown,
		Static,
		IFrame,
		Html
	}

	[Native]
	public enum YMAIconHorizontalPosition : ulong
	{
		Left,
		Right,
		LeftOffset
	}

	[Native]
	public enum YMAIconVerticalPosition : ulong
	{
		Top,
		Bottom,
		TopOffset
	}
}
