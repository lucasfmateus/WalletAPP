using Gem.Bindings;
using Prism.Navigation;
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