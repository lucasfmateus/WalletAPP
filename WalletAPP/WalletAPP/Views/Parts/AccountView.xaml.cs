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
        }

        #region Bindings
        #endregion
    }

}