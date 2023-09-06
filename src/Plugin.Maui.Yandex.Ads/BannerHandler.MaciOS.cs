using CoreGraphics;
using Microsoft.Maui.Handlers;
using Plugin.Maui.Yandex.Ads.iOS;
using UIKit;

namespace Plugin.Maui.Yandex.Ads;

public partial class BannerHandler : ViewHandler<Banner, YMAAdView>
{

	public static void MapAdUnitId(BannerHandler handler, Banner banner)
	{
		//handler.PlatformView?.SetAdUnitId(banner.AdUnitId);
	}

	protected override YMAAdView CreatePlatformView()
	{
		var s = YMAAdSize.YMAAdSizeBanner_300x250;
		var inl = YMAAdSize.FlexibleSizeWithCGSize(s);
		// = s;
		var banner = new YMAAdView(VirtualView.AdUnitId,inl,new YMAAdViewDelegate());
		//var banner = new YMAAdView();
		banner.LoadAd();
		return banner;
	}
}
