using Gem.Bindings;
using WalletAPP.Models;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalletAPP.Views.Parts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountView : ContentView
    {
        public AccountView()
        {
            InitializeComponent();
        }
    }
    public class AccountViewModel : ViewModelBase
    {
        #region Services
        public AccountViewModel(ViewModelBaseServices viewModelBaseServices) : base(viewModelBaseServices)
        {

        }
        #endregion

        public override async Task Load(INavigationParameters parameters)
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
                        Title = "PONTOS",
                        Currency = "SD$",
                        Value = 10000000
                    },
                    new AccountFunds
                    {
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