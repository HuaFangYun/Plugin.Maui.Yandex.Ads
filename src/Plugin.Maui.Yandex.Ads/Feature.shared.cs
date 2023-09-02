
/* Unmerged change from project 'Plugin.Maui.Yandex.Ads (net7.0)'
Before:
using Plugin.Maui.Yandex.Ads;
After:
using Plugin;
using Plugin.Maui;
using Plugin.Maui.Feature;
using Plugin.Maui.Yandex.Ads;
*/

/* Unmerged change from project 'Plugin.Maui.Yandex.Ads (net7.0-ios)'
Before:
using Plugin.Maui.Yandex.Ads;
After:
using Plugin;
using Plugin.Maui;
using Plugin.Maui.Feature;
using Plugin.Maui.Yandex.Ads;
*/

/* Unmerged change from project 'Plugin.Maui.Yandex.Ads (net7.0-maccatalyst)'
Before:
using Plugin.Maui.Yandex.Ads;
After:
using Plugin;
using Plugin.Maui;
using Plugin.Maui.Feature;
using Plugin.Maui.Yandex.Ads;
*/

/* Unmerged change from project 'Plugin.Maui.Yandex.Ads (net7.0-windows10.0.19041.0)'
Before:
using Plugin.Maui.Yandex.Ads;
After:
using Plugin;
using Plugin.Maui;
using Plugin.Maui.Feature;
using Plugin.Maui.Yandex.Ads;
*/
using Plugin.Maui.Feature;

namespace Plugin.Maui.Yandex.Ads;

public static class Feature
{
    static IBannerAd defaultImplementation;

    /// <summary>
    /// Provides the default implementation for static usage of this API.
    /// </summary>
    public static IBannerAd Default =>
        defaultImplementation ??= new FeatureImplementation();

    internal static void SetDefault(IBannerAd implementation) =>
        defaultImplementation = implementation;
}
