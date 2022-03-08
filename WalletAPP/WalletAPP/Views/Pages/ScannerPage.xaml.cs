using Gem.Bindings;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalletAPP.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScannerPage : ContentPage
    {
        public ScannerPage()
        {
            InitializeComponent();
        }

        //private async void CameraView_OnDetected(object sender, GoogleVisionBarCodeScanner.OnDetectedEventArg e)
        //{
        //    List<GoogleVisionBarCodeScanner.BarcodeResult> obj = e.BarcodeResults;

        //    string result = string.Empty;
        //    for (int i = 0; i < obj.Count; i++)
        //    {
        //        result += $"Type : {obj[i].BarcodeType}, Value : {obj[i].DisplayValue}{Environment.NewLine}";
        //    }
        //    Device.BeginInvokeOnMainThread(async () =>
        //    {
        //        await DisplayAlert("Result", result, "OK");
        //        //GoogleVisionBarCodeScanner.Methods.SetIsScanning(true);
        //        await Navigation.PopModalAsync();
        //    });
        //}
    }

    public class ScannerViewModel : ViewModelBase
    {
        public ScannerViewModel(ViewModelBaseServices viewModelBaseServices) : base(viewModelBaseServices)
        {
        }

        public override async Task Load(INavigationParameters parameters)
        {

        }
    }
}