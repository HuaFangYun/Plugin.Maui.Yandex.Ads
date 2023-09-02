namespace Plugin.Maui.Yandex.Ads;
public static class Extensions
{
	public static IMauiHandlersCollection RegisterYandexAds(this IMauiHandlersCollection handlers)
	{
		handlers.AddHandler(typeof(Banner), typeof(BannerHandler));
		return handlers;
	}
}
