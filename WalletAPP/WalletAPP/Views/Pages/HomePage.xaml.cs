using Gem.Bindings;
using WalletAPP.Views.Parts;
using WalletAPP.Views.Shell;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Events;

namespace WalletAPP.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomeViewModel Vm => (HomeViewModel)BindingContext;

        public HomePage()
        {
            InitializeComponent();
        }

        void NavigationDrawer()
        {
            navigationDrawer.ToggleDrawer();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (Vm != null)
            {
                Vm.EventAggregator?.GetEvent<NavigationDrawerStatusChanged>().Subscribe(NavigationDrawer, ThreadOption.UIThread);
                //homeTabView.SelectionChanged += HomeTabView_SelectionChanged;
            }
        }

        private void HomeTabView_Focused(object sender, FocusEventArgs e)
        {
            //homeTabView.SelectionChanged += HomeTabView_SelectionChanged;
        }

        private void Unfocused(object sender, FocusEventArgs e)
        {
            //homeTabView.SelectionChanged -= HomeTabView_SelectionChanged;
        }

        private async void HomeTabView_SelectionChanged(object sender, Syncfusion.XForms.TabView.SelectionChangedEventArgs e)
        {
            if (Vm != null)
            {
                await Vm.LoadTab();
            }
        }
    }

    public class HomeViewModel : ViewModelBase
    {
        #region Services
        public HomeViewModel(
            ViewModelBaseServices viewModelBaseServices, 
            DashboardViewModel dashboardViewModel, 
            TransactionViewModel transactionViewModel,
            WalletViewModel chartsVM, 
            NotificationViewModel notificationVM
            ) : base(viewModelBaseServices)
        {
            DashboardVM = dashboardViewModel;
            ChartsVM = chartsVM;
            TransactionVM = transactionViewModel;
            NotificationVM = notificationVM;
        }
        #endregion

        public override async Task Load(INavigationParameters parameters)
        {
            try
            {
                await LoadTab();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        public async Task LoadTab()
        {
            await DashboardVM.Load();
            await TransactionVM.Load();
            await ChartsVM.Load();
            await NotificationVM.Load();

            //switch (SelectedTab)
            //{
            //    case (0):
            //        await DashboardVM.Load(null);
            //        break;
            //    case (1):
            //        await TransactionVM.Load(null);
            //        break;
            //    default:
            //        break;
            //}
        }

        //public Command QRPayment => new Command(async () =>
        //{
        //    //await CrossPermissions.Current.RequestPermissionsAsync(Permission.Camera);

        //    bool allowed = false;
        //    allowed = await GoogleVisionBarCodeScanner.Methods.AskForRequiredPermission();
        //    if (allowed)
        //    {
        //        var navPar = new NavigationParameters
        //        {
        //            {"Page", nameof(HomePage) },
        //        };
        //        await NavigationService.NavigateAsync(nameof(ShellNavigationPage) + "/" + nameof(ScannerPage), navPar);
        //    }
        //});

        #region Binding

        private int _selectedTab = 0;
        public int SelectedTab
        {
            get { return _selectedTab; }
            set { SetProperty(ref _selectedTab, value); }
        }

        private DashboardViewModel _dashboardVM;
        public DashboardViewModel DashboardVM
        {
            get { return _dashboardVM; }
            set { SetProperty(ref _dashboardVM, value); }
        }

        private TransactionViewModel _transactionVM;
        public TransactionViewModel TransactionVM
        {
            get { return _transactionVM; }
            set { SetProperty(ref _transactionVM, value); }
        }

        private WalletViewModel _chartsVM;
        public WalletViewModel ChartsVM
        {
            get { return _chartsVM; }
            set { SetProperty(ref _chartsVM, value); }
        }

        private NotificationViewModel _notificationVM;
        public NotificationViewModel NotificationVM
        {
            get { return _notificationVM; }
            set { SetProperty(ref _notificationVM, value); }
        }

        private bool _isLoading = false;
        public bool IsLoading
        {
            get { return _isLoading; }
            set { SetProperty(ref _isLoading, value); }
        }

        #endregion
    }

    public class NavigationDrawerStatusChanged : PubSubEvent
    {
    }

}