using Microsoft.Maui.Handlers;
using UIKit;

namespace Plugin.Maui.Yandex.Ads;

public partial class BannerHandler : ViewHandler<Banner, UIButton>
{

	public static void MapAdUnitId(BannerHandler handler, Banner banner)
	{
		//handler.PlatformView?.SetAdUnitId(banner.AdUnitId);
	}

	protected override UIButton CreatePlatformView()
	{
		//YMAAdView
		//var benner = new 
		return new UIButton();
	}
}
