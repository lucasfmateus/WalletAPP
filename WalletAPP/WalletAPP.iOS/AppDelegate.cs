using Foundation;
using Plugin.Iconize;
using Prism;
using Prism.Ioc;
using Syncfusion.ListView.XForms.iOS;
using UIKit;
using WalletAPP.iOS.Services;
using WalletAPP.Services.Base;

namespace WalletAPP.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();


            FFImageLoading.Forms.Platform.CachedImageRenderer.Init();
            Syncfusion.XForms.iOS.Core.SfAvatarViewRenderer.Init();
            new Syncfusion.SfNavigationDrawer.XForms.iOS.SfNavigationDrawerRenderer();
            Syncfusion.XForms.iOS.TabView.SfTabViewRenderer.Init();
            Syncfusion.XForms.iOS.Border.SfBorderRenderer.Init();
            Syncfusion.XForms.iOS.PopupLayout.SfPopupLayoutRenderer.Init();
            Syncfusion.XForms.iOS.TextInputLayout.SfTextInputLayoutRenderer.Init();
            Syncfusion.SfCarousel.XForms.iOS.SfCarouselRenderer.Init();
            SfListViewRenderer.Init();
          //  GoogleVisionBarCodeScanner.iOS.Initializer.Init();
            Firebase.Core.App.Configure();

            Iconize.Init();
            Iconize.With(new Plugin.Iconize.Fonts.MaterialDesignIconsModule())
                    .With(new Plugin.Iconize.Fonts.MaterialModule());


            LoadApplication(new App(new iOSInitializer()));

            return base.FinishedLaunching(app, options);
        }
    }

    public class iOSInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ISQLiteService, SQLiteService_iOS>();
        }
    }
}
