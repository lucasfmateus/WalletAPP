using Gem.Bindings;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WalletAPP.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalletAPP.Views.Parts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WalletView : ContentView
    {
        public WalletView()
        {
            InitializeComponent(); 
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //var styleKit = new StyleKit();

            //if(favorit.IconColor == Color.LightGray)
            //{
            //    favorit.IconColor = styleKit.SecondaryColor;
            //}
            //else
            //{
            //    favorit.IconColor = Color.LightGray;
            //}

        }
    }

    public class WalletViewModel : ViewModelBase
    {
        public WalletViewModel(ViewModelBaseServices viewModelBaseServices) : base(viewModelBaseServices)
        {
        }

        public override async Task Load(INavigationParameters parameters = null)
        {

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

        #region Bindings
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