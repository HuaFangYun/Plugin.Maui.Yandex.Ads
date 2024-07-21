using Plugin.Maui.Yandex.Metrika;
namespace Sample;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		new AppMetricaAnalytics().TrackEvent("net8", "Hello from maui");
	}
}

