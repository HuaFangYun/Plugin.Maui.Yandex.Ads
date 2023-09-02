using Android.Content;
using Com.Yandex.Mobile.Ads.Banner;
using Com.Yandex.Mobile.Ads.Common;

namespace Plugin.Maui.Yandex.Ads;

partial class BannerAdImplementation : ViewHandler<BannerAd, BannerAdView>, IBannerAd
{
	protected override BannerAdView CreatePlatformView()
	{

		var bannerAd = new BannerAdView(Context);
		//bannerAd.AdFailedToLoad += S_AdFailedToLoad;
		//bannerAd.AdLoaded += AdLoaded;
		//bannerAd.SetAdSize(new AdSize(320, 50));

		bannerAd.SetMinimumHeight(50);
		bannerAd.SetMinimumWidth(320);
		bannerAd.SetAdUnitId("R-M-DEMO-320x50");

	

		var adRequest = new AdRequest.Builder()
		 // .SetParameters(getRequestParameters())
		 .Build();

		bannerAd?.LoadAd(adRequest);

		// s.SetAdUnitId("R-M-DEMO-native-i");
		return bannerAd;
	}
}