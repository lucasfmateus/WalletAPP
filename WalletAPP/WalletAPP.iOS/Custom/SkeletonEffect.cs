using System;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("Skeleton")]
[assembly: ExportEffect(typeof(WalletAPP.iOS.Custom.SkeletonEffect), nameof(WalletAPP.iOS.Custom.SkeletonEffect))]
namespace WalletAPP.iOS.Custom
{
    public class SkeletonEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Color bgColor = Color.FromHex("#FFECECEC");
            var toggle = (UILabel)Control;
            toggle.TextColor = bgColor.ToUIColor();
            toggle.BackgroundColor = bgColor.ToUIColor();
        }

        protected override void OnDetached()
        {
            var theme = new StyleKit();

            var toggle = (UILabel)Control;

            toggle.TextColor = theme.BackgroundColorPage.ToUIColor();
            toggle.BackgroundColor = theme.PrimaryTextColor.ToUIColor();
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            Color bgColor = Color.FromHex("#FFECECEC");
            var toggle = (UILabel)Control;
            toggle.TextColor = bgColor.ToUIColor();
            toggle.BackgroundColor = bgColor.ToUIColor();

        }
    }
}