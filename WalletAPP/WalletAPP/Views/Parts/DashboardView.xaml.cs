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

        //private void CarouselViewContent_SizeChanged(object sender, EventArgs e) 
        //{ 
        //    var contentSize = ((VisualElement)sender).Height; 
        //    if (contentSize > banner.HeightRequest) 
        //    {
        //        banner.HeightRequest = contentSize; 
        //    } 
        //}

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
                //Banners = new Banner
                //{
                //    Time = 5,
                //    ImageUrl = new List<string>
                //    {
                //        "https://thumbs.dreamstime.com/b/smart-wallet-banner-mobile-payment-concept-vector-landing-page-electronic-finance-isometric-icon-virtual-banking-card-199231196.jpg",
                //        "https://neilpatel.com/wp-content/uploads/2019/12/ilustracao-sobre-cashback-e-como-funciona.jpeg"
                //    }
                //};

                Funds = new Fund
                {
                    Abbreviation = "R$",
                    Balance = 0.0M,
                    DecimalPlaces = 2,
                    Id = "1",
                    Name = "SALDO"
                };

                Wallets = new List<CoinWallet>
                {
                    new CoinWallet
                    {
                        Id = "1",
                        Name = "DOLAR",
                        Balance = 787.41M,
                        Coin = new Coin
                        {
                            Abbreviation =  "BUSD",
                            DecimalPlaces = 2,
                            Name = "DOLAR",
                            Id = "1"
                        }
                    },
                    new CoinWallet
                    {
                        Id = "2",
                        Name = "REAL",
                        Balance = 0.39M,
                        Coin = new Coin
                        {
                            Abbreviation =  "BRL",
                            DecimalPlaces = 2,
                            Name = "REAL",
                            Id = "2"
                        }
                    },
                    new CoinWallet
                    {
                        Id = "3",
                        Name = "BINANCE",
                        Balance = 0.05M, 
                        Coin = new Coin
                        {
                            Abbreviation =  "BNB",
                            DecimalPlaces = 2,
                            Name = "BINANCE",
                            Id = "3"
                        }
                    },
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
        
        private Fund _funds;
        public Fund Funds
        {
            get { return _funds; }
            set { SetProperty(ref _funds, value); }
        }

        private List<CoinWallet> _wallets;
        public List<CoinWallet> Wallets
        {
            get { return _wallets; }
            set { SetProperty(ref _wallets, value); }
        }

        #endregion
    }
}