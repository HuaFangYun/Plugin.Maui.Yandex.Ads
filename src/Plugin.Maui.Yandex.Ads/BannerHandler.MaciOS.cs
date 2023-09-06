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
		//var banner = new YMAAdView("",s new YMAAdViewDelegate(()));
		var banner = new YMAAdView();
		banner.LoadAd();
		return banner;
	}
}
