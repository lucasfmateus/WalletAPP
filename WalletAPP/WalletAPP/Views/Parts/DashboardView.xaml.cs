using Gem.Bindings;
using Plugin.Iconize;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalletAPP.Models;
using WalletAPP.Utils;
using WalletAPP.Views.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalletAPP.Views.Parts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardView : ContentView
    {
        private DashboardViewModel Vm => BindingContext as DashboardViewModel;

        public DashboardView()
        {
            InitializeComponent();
        }

        private void Tapped_ChangeVisibility(object sender, EventArgs e)
        {
            var iconImage = sender as IconImage;
            iconImage.Icon = iconImage.Icon  == "mdi-eye-off-outline" ? "mdi-eye-outline" : "mdi-eye-off-outline";
        }

        private void CarouselViewContent_SizeChanged(object sender, EventArgs e) 
        { 
            var contentSize = ((VisualElement)sender).Height; 
            if (contentSize > banner.HeightRequest) 
            {
                banner.HeightRequest = contentSize; 
            } 
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Vm.EventAggregator.GetEvent<NavigationDrawerStatusChanged>().Publish();
        }
    }


    public class DashboardViewModel : ViewModelBase
    {
        #region Services
        public DashboardViewModel(ViewModelBaseServices viewModelBaseServices) : base(viewModelBaseServices)
        {

        }
        #endregion

        public override async Task Load(INavigationParameters parameters = null)
        {
            try
            {
                Banners = new Banner
                {
                    Time = 5,
                    ImageUrl = new List<string>
                    {
                        "https://thumbs.dreamstime.com/b/smart-wallet-banner-mobile-payment-concept-vector-landing-page-electronic-finance-isometric-icon-virtual-banking-card-199231196.jpg",
                        "https://neilpatel.com/wp-content/uploads/2019/12/ilustracao-sobre-cashback-e-como-funciona.jpeg"
                    }
                };

                Funds = new List<AccountFunds>
                {
                    new AccountFunds
                    {
                        Id = "1",
                        Title = "PONTOS",
                        Currency = "SD$",
                        Value = 10000000
                    },
                    new AccountFunds
                    {
                        Id = "2",
                        Title = "CARTEIRA DIGITAL",
                        Currency = "R$",
                        Value = 5000
                    }
                };
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        public Command<Label> CommandChange => new Command<Label>(async (x) => 
        {
            if (x.Effects.Any())
            {
                x.Effects.Clear();
            }
            else
            {
                x.Effects.Add(new SkeletonEffect());
            }
        });

        #region Bindings
        private Banner _banners;
        public Banner Banners
        {
            get { return _banners; }
            set { SetProperty(ref _banners, value); }
        }

        private List<AccountFunds> _funds;
        public List<AccountFunds> Funds
        {
            get { return _funds; }
            set { SetProperty(ref _funds, value); }
        }

        #endregion
    }
}