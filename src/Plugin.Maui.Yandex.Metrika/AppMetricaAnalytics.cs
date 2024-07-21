#if ANDROID
using AppMetrica = Com.Yandex.Metrica;
using Utils = Java.Util;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID)
using AppMetrica = System.Object;
using Utils = System.Object;
#endif

namespace Plugin.Maui.Yandex.Metrika;


public class AppMetricaAnalytics
{
    public void ReportError(Exception ex)
    {
        // todo: c# Exception to java Exception
        AppMetrica.YandexMetrica.ReportError(ex.Message, ex.Message);
    }

    public void ReportRevenue(double price, string currency)
    {
        var revenue = AppMetrica.Revenue.NewBuilder(price, Utils.Currency.GetInstance(currency)).Build();
        AppMetrica.YandexMetrica.ReportRevenue(revenue);
    }

    public void TrackEvent(string eventName)
    {
        AppMetrica.YandexMetrica.ReportEvent(eventName);
    }

    public void TrackEvent(string eventName, string param)
    {
        AppMetrica.YandexMetrica.ReportEvent(eventName, param);
    }
}
