using Microsoft.Maui.Handlers;
using UIKit;

namespace Plugin.Maui.Yandex.Ads;

public partial class BannerHandler : ViewHandler<Banner, UIButton>
{
	//public BannerHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
	//{
	//}

	protected override UIButton CreatePlatformView()
	{
		return new UIButton();
	}
}
