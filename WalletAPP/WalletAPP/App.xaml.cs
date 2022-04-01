using Gem;
using Gem.AppCenter;
using Gem.Bindings;
using Gem.UX;
using WalletAPP.Views.Pages;
using WalletAPP.Views.Shell;
using Plugin.Iconize;
using Prism;
using Prism.AppModel;
using Prism.Ioc;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WalletAPP
{
    public partial class App : GemApp
    {
        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
            AppCenterExt.Initialize("626a0f49-b401-4d64-9837-7f4e87a2c82d");
            Iconize
                .With(new Plugin.Iconize.Fonts.MaterialDesignIconsModule())
                .With(new Plugin.Iconize.Fonts.MaterialModule())
                .With(new Plugin.Iconize.Fonts.JamIconsModule())
                ;
        }

        public override void Configure(GemAppOptions options)
        {
            options.UseAppCenter = true;
            options.InitializerType = typeof(GerminiInitializer);
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            StyleKit = Container.Resolve<GerminiStyleKit>();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTkyNTQyQDMxMzcyZTM0MmUzMEpZVmR6VlhrY3BJcVN0VXUrakNDZmovQ05Jd291SFZTRXZGOXhoeEUyeU09");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ShellNavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>();
            containerRegistry.RegisterForNavigation<ScannerPage, ScannerViewModel>();
        }
    }

    public class GerminiStyleKit : MaterialStyleKit
    {
        public GerminiStyleKit()
        {
            PrimaryColor = Color.FromHex("#FF0769ca");

            PrimaryColorDark = Color.FromHex("#FF26648E");

            SecondaryColor = Color.FromHex("#ffbf00");

            TextColorOfPrimaryColor = Color.FromHex("#FFFFFF");

            TextColorOfAccentColor = Color.FromHex("#FF2F5F83");

            DisabledTextColor = Color.FromHex("#FF999999");

            AccentColor = Color.FromHex("#2196F3");

            BackgroundColorAppBar = Color.FromHex("#FFFFFF");

            BackgroundColorPage = Color.FromHex("#F2F2F2");

            SecondaryTextColor = Color.FromHex("#1b4765");

        }
    }

    public class GerminiInitializer : AppInitializer
    {
        public GerminiInitializer(GemAppOptions appOptions, ApplicationStore applicationStore, ViewModelBaseServices viewModelBaseServices) : base(appOptions, applicationStore, viewModelBaseServices)
        {
        }

        public override async Task InitializeAsync()
        {
            try
            {
                //await NavigationService.NavigateAsync("app:///" + nameof(HomePage));
                await NavigationService.NavigateAsync("app:///" + nameof(ShellNavigationPage) + "/" + nameof(HomePage));
            }
            catch (System.Exception ex)
            {
                HandleException(ex);
            }
        }
    }
}
