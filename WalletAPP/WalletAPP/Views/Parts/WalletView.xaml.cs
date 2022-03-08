using Gem.Bindings;
using WalletAPP.Models;
using WalletAPP.Utils;
using Prism.Navigation;
using Syncfusion.DataSource;
using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

    public class WalletViewModel : ViewModelBase
    {
        public WalletViewModel(ViewModelBaseServices viewModelBaseServices) : base(viewModelBaseServices)
        {
        }

        public override async Task Load(INavigationParameters parameters = null)
        {
            Data = new List<Chart>()
            {
                 new Chart{ Date = DateTime.Now, Value = 1},
                 new Chart{ Date = DateTime.Now.AddDays(-1), Value = 3},
                 new Chart{ Date = DateTime.Now.AddDays(-2), Value = 13},
                 new Chart{ Date = DateTime.Now.AddDays(-3), Value = 21},
                 new Chart{ Date = DateTime.Now.AddDays(-4), Value = -7},
                 new Chart{ Date = DateTime.Now.AddDays(-5), Value = -11},
            };

            //Data = new List<Person>()
            //{
            //    new Person { Name = "David", Height = 180 },
            //    new Person { Name = "Michael", Height = 170 },
            //    new Person { Name = "Steve", Height = 160 },
            //    new Person { Name = "Joel", Height = 182 }
            //};
        }

        private List<Chart> data;

        public List<Chart> Data
        {
            get { return data; }
            set { SetProperty(ref data, value); }
        }

    }
    public class Person
    {
        public string Name { get; set; }

        public double Height { get; set; }
    }
    public class Chart
    {
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
    }

}