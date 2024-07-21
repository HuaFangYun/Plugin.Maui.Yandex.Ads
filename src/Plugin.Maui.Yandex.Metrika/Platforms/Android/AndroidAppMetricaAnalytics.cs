using Com.Yandex.Metrica;
using Java.Util;

namespace Plugin.Maui.Yandex.Metrika;

public class AndroidAppMetricaAnalytics
{
    public void Init(string apiKey)
    {
        var config = YandexMetricaConfig.NewConfigBuilder(apiKey).Build();
        YandexMetrica.Activate(Platform.AppContext, config);
    }

    // public void ReportRevenue(double price, string currency)
    // {
    //     var revenue = Revenue.NewBuilder(price, Currency.GetInstance(currency)).Build();
    //     YandexMetrica.ReportRevenue(revenue);
    // }
}
