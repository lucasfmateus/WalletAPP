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
            try
            {
                Xamarin.Forms.Color bgColor = Xamarin.Forms.Color.FromHex("#FFECECEC");
                var toggle = (UILabel)Control;
                toggle.TextColor = bgColor.ToUIColor();
                toggle.BackgroundColor = bgColor.ToUIColor();
            }
            catch (Exception ex)
            {
            }
        }

        protected override void OnDetached()
        {
            var theme = new GerminiStyleKit();

            var toggle = (UILabel)Control;


            toggle.TextColor = theme.BackgroundColorPage.ToUIColor();
            toggle.BackgroundColor = theme.PrimaryTextColor.ToUIColor();
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            try
            {
                Xamarin.Forms.Color bgColor = Xamarin.Forms.Color.FromHex("#FFECECEC");
                var toggle = (UILabel)Control;
                toggle.TextColor = bgColor.ToUIColor();
                toggle.BackgroundColor = bgColor.ToUIColor();
            }
            catch (Exception ex)
            {
            }
        }
    }
}