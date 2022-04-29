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
                        Balance = 787.41M,
                        Coin = new Coin
                        {
                            Abbreviation = "SD$",
                            Symbol = "https://scontent.fbfh9-1.fna.fbcdn.net/v/t1.6435-9/117933338_880846769111005_8671486982752218507_n.png?_nc_cat=111&ccb=1-5&_nc_sid=09cbfe&_nc_eui2=AeGo_X_GmcFuACZmHM59WKAlON3--HKUa_M43f74cpRr8zhpe8Si_wmuJ5kEazXMpCGf3PiQeA0rDBJL6hgjjofN&_nc_ohc=pnVaAfwYqhIAX_nO13G&_nc_ht=scontent.fbfh9-1.fna&oh=00_AT9AHWgiSomrjkwEwY5K1ZdIR8WcE76Tkx8xpTid0dJ4Zw&oe=6291FC56",
                            DecimalPlaces = 2,
                            Name = "SEEDS",
                            Id = "1"
                        }
                    },
                    new CoinWallet
                    {
                        Id = "2",
                        Balance = 0.39M,
                        Coin = new Coin
                        {
                            Abbreviation = "BK$",
                            Symbol = "https://scontent.fbfh9-1.fna.fbcdn.net/v/t1.6435-9/88248359_213586670027043_6946853711423471616_n.jpg?_nc_cat=107&ccb=1-5&_nc_sid=09cbfe&_nc_eui2=AeHSSaDcwLY6fG8C6lmxzTSIqCSgMR0B-KaoJKAxHQH4pr8ywEBUSKZybKpE096Ve7ESYt4A91Z-URODs3lS6TF-&_nc_ohc=pD9uwg72IuYAX_OV7jw&tn=wSQkmp20O9kB9WKw&_nc_ht=scontent.fbfh9-1.fna&oh=00_AT-5h-Nw12ZlItNU1JHb3-nF8nYGbf7-7szC_tsTmACrUA&oe=62939F90",
                            DecimalPlaces = 2,
                            Name = "B2K",
                            Id = "2"
                        }
                    },
                    new CoinWallet
                    {
                        Id = "3",
                        Balance = 0.05M, 
                        Coin = new Coin
                        {
                            Abbreviation = "SPR$",
                            Symbol = "https://media.glassdoor.com/sqll/2485853/spro-it-solutions-squarelogo-1553472085617.png",
                            DecimalPlaces = 2,
                            Name = "SPRO GROUP",
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
        //private Banner _banners;
        //public Banner Banners
        //{
        //    get { return _banners; }
        //    set { SetProperty(ref _banners, value); }
        //}
        
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