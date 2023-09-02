using Microsoft.Maui.Handlers;
using Com.Yandex.Mobile.Ads.Banner;
using Android.Widget;
using Com.Yandex.Mobile.Ads.Common;
using Plugin.Maui.Yandex.Ads;

namespace Plugin.Maui.Yandex.Ads;

public partial class BannerHandler : ViewHandler<Banner, BannerAdView>
{
	protected override BannerAdView CreatePlatformView()
	{

		var bannerAd = new BannerAdView(Context);
		//bannerAd.AdFailedToLoad += S_AdFailedToLoad;
		//bannerAd.AdLoaded += AdLoaded;
		bannerAd.SetAdSize(new AdSize(320, 50));

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



	//private void AdLoaded(object sender, EventArgs e)
	//{
	//   // throw new NotImplementedException();
	//}

	//private void S_AdFailedToLoad(object sender, AdFailedToLoadEventArgs e)
	//{
	//    //throw new NotImplementedException();
	//}

}
