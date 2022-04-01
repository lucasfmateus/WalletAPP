using System;
using System.ComponentModel;
using WalletAPP.Droid.Custom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Skeleton")]
[assembly: ExportEffect(typeof(SkeletonEffect), nameof(SkeletonEffect))]
namespace WalletAPP.Droid.Custom
{
    public class SkeletonEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Color bgColor = Color.FromHex("#FFECECEC");

            var toggle = (Android.Widget.TextView)Control;
            toggle.SetTextColor(bgColor.ToAndroid());
            toggle.SetBackgroundColor(bgColor.ToAndroid());

        }

        protected override void OnDetached()
        {
            var toggle = (Android.Widget.TextView)Control;

            toggle.SetTextColor(Android.Graphics.Color.Black);

            toggle.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            Color bgColor = Color.FromHex("#FFECECEC");

            var toggle = (Android.Widget.TextView)Control;
            toggle.SetTextColor(bgColor.ToAndroid());
            toggle.SetBackgroundColor(bgColor.ToAndroid());

        }
    }
}