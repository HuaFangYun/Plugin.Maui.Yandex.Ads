using Android.App;
using Android.Content.PM;
using Android.OS;
using Plugin.Maui.Yandex.Metrika;

namespace Sample;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
	protected override void OnCreate(Bundle? savedInstanceState)
	{
		base.OnCreate(savedInstanceState);
      // new AndroidAppMetricaAnalytics().Init(this, "402666bf-8ba8-4239-b5b0-dac9c120dba8");
	}
}
