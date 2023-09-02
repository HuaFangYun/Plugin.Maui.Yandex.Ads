using Plugin.Maui.Yandex.Ads;

namespace Plugin.Maui.Feature;

partial class BannerAdImplementation : IBannerAd
{

	public static IPropertyMapper<BannerAd, BannerAdImplementation> PropertyMapper = new PropertyMapper<Banner, BannerHandler>(ViewHandler.ViewMapper)
	{
		//[nameof(Video.AreTransportControlsEnabled)] = MapAreTransportControlsEnabled,
		//[nameof(Video.Source)] = MapSource,
		//[nameof(Video.IsLooping)] = MapIsLooping,
		//[nameof(Video.Position)] = MapPosition
	};

	public static CommandMapper<BannerAd, BannerAdImplementation> CommandMapper = new(ViewCommandMapper)
	{
		//[nameof(Video.UpdateStatus)] = MapUpdateStatus,
		//[nameof(Video.PlayRequested)] = MapPlayRequested,
		//[nameof(Video.PauseRequested)] = MapPauseRequested,
		//[nameof(Video.StopRequested)] = MapStopRequested
	};

	public BannerAd() : base(PropertyMapper, CommandMapper)
	{
	}
}