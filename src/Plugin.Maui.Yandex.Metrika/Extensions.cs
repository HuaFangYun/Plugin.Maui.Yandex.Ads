namespace Plugin.Maui.Yandex.Metrika;

public static class Extensions
{
    public static MauiAppBuilder RegisterAppMetrica(this MauiAppBuilder mauiAppBuilder, string apiKey)
    {
        new AndroidAppMetricaAnalytics().Init(apiKey);
        return mauiAppBuilder;
    }
}


