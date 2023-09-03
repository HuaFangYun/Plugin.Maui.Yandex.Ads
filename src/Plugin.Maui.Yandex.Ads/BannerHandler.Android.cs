using Com.Yandex.Mobile.Ads.Banner;
using Com.Yandex.Mobile.Ads.Common;
using Microsoft.Maui.Handlers;

namespace Plugin.Maui.Yandex.Ads;

public partial class BannerHandler : ViewHandler<Banner, BannerAdView>
{
	public static void MapAdUnitId(BannerHandler handler, Banner banner)
	{
		//handler.PlatformView?.SetAdUnitId(banner.AdUnitId);
	}

	protected override BannerAdView CreatePlatformView()
	{
		var bannerAd = new BannerAdView(Context);
		//bannerAd.AdFailedToLoad += S_AdFailedToLoad;
		//bannerAd.AdLoaded += AdLoaded;
		//bannerAd.SetAdSize(new AdSize(320, 50));
		bannerAd.SetAdSize(AdSize.BANNER320x50);
		bannerAd.SetMinimumHeight(50);
		bannerAd.SetMinimumWidth(320);
		//bannerAd.SetAdUnitId("R-M-DEMO-320x50");

		bannerAd.SetAdUnitId(this.VirtualView.AdUnitId);
		var adRequest = new AdRequest.Builder()
		 .Build();

		bannerAd?.LoadAd(adRequest);
		return bannerAd;
	}



	//private void AdLoaded(object sender, EventArgs e)
	//{
	//   // throw new NotImplementedException();
	//}

	//private void S_AdFailedToLoad(object sender, AdFailedToLoadEventArgs e)
	//{
	//    //throw new NotImplementedException();
	//}

}
