using Gem.Bindings;
using Prism.Navigation;
using Syncfusion.XForms.PopupLayout;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WalletAPP.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalletAPP.Views.Parts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransactionView : ContentView
    {
        TransactionViewModel Vm => BindingContext as TransactionViewModel;

        public TransactionView()
        {
            InitializeComponent();

            //listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
            //{
            //    KeySelector = (object obj1) =>
            //    {
            //        var item = obj1 as Transaction;
            //        return item.Date;
            //    },
            //});

            var c = new Command<Transaction>((bs) => Vm.ShowPopupFilterCommand.Execute(bs));
            //listView.TapSelection(c);

        }

        private async void FilterTabView_SelectionChanged(object sender, Syncfusion.XForms.TabView.SelectionChangedEventArgs e)
        {
            await Vm?.RefreshData();
        }

        private async void carousel_SelectionChanged(object sender, Syncfusion.SfCarousel.XForms.SelectionChangedEventArgs e)
        {
            await Vm?.RefreshData();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Vm != null)
            {

                var parameter = ((TappedEventArgs)e).Parameter as PeriodItem;

                var itemIndex = await Vm.GetSelectedIndex(parameter.Month, parameter.Year);

                if (Vm.SelectedItemIndex == itemIndex)
                {
                    Vm?.ShowPopupFilterCommand.Execute(null);
                }
                else
                {
                    carousel.SelectedIndex = itemIndex;
                    Vm.SelectedItemIndex = itemIndex;
                }

            }
        }
    }

    public class TransactionViewModel : ViewModelBase
    {
        #region Services
        public TransactionViewModel(ViewModelBaseServices viewModelBaseServices) : base(viewModelBaseServices)
        {
        }
        #endregion

        public override async Task Load(INavigationParameters parameters = null)
        {
            await PopulatePeriodItemsList();

            await RefreshData();
        }

        public async Task RefreshData()
        {
            BusyLoader.SetIsLoading(true);

            var filterPeriod = FilterPeriodItemList[SelectedItemIndex - 1];

            switch (SelectedTab)
            {
                case (0):
                    Transactions = new List<Transaction>
                    {
                        new Transaction
                        {
                            Id = "1",
                            Date = DateTime.Now.Date,
                            NF = "12345678",
                            PartnerName = "C.Vale",
                            PointsRedeemed = 639,
                            Value = 63.9M,
                            TransactionType = TransactionType.Program,
                        },
                        new Transaction
                        {
                            Id = "5",
                            Date = DateTime.Now.Date,
                            NF = "123456789",
                            PartnerName = "C.Vale",
                            PointsRedeemed = 2000,
                            TransactionType = TransactionType.Program,
                        },
                        new Transaction
                        {
                            Id = "2",
                            Date = DateTime.Now.Date,
                            NF = "123456780",
                            PartnerName = "C.Vale",
                            Value = 49.9M,
                            TransactionType = TransactionType.Program,
                        },
                        new Transaction
                        {
                            Id = "3",
                            Date = DateTime.Now.Date.AddDays(-1),
                            NF = "123456781",
                            PartnerName = "C.Vale",
                            PointsRedeemed = 1499,
                            Value = 149.9M,
                            TransactionType = TransactionType.Program,
                        },
                        new Transaction
                        {
                            Id = "4",
                            Date = DateTime.Now.Date.AddDays(-2),
                            NF = "123456783",
                            PartnerName = "C.Vale",
                            PointsRedeemed = 2349,
                            Value = 234.9M,
                            TransactionType = TransactionType.Program,
                        },
                        new Transaction
                        {
                            Id = "5",
                            Date = DateTime.Now.Date,
                            NF = "123456789",
                            PartnerName = "C.Vale",
                            PointsRedeemed = 2309,
                            TransactionType = TransactionType.Currency,
                        },
                        new Transaction
                        {
                            Id = "2",
                            Date = DateTime.Now.Date,
                            NF = "123456780",
                            PartnerName = "C.Vale",
                            Value = 723.9M,
                            TransactionType = TransactionType.Currency,
                        },
                        new Transaction
                        {
                            Id = "3",
                            Date = DateTime.Now.Date.AddDays(-1),
                            NF = "123456781",
                            PartnerName = "C.Vale",
                            PointsRedeemed = 2999,
                            Value = 299.9M,
                            TransactionType = TransactionType.Currency,
                        },
                        new Transaction
                        {
                            Id = "4",
                            Date = DateTime.Now.Date.AddDays(-2),
                            NF = "123456783",
                            PartnerName = "C.Vale",
                            PointsRedeemed = 3499,
                            Value = 349.9M,
                            TransactionType = TransactionType.Currency,
                        },
                    };
                    break;
                case (1):
                    Transactions = new List<Transaction>
                    {
                        new Transaction
                        {
                            Id = "1",
                            Date = DateTime.Now.Date,
                            NF = "12345678",
                            PartnerName = "C.Vale Fidelidade",
                            PointsRedeemed = 500,
                            Value = 249.9M
                        },
                        new Transaction
                        {
                            Id = "5",
                            Date = DateTime.Now.Date,
                            NF = "123456789",
                            PartnerName = "C.Vale Fidelidade",
                            PointsRedeemed = 500,
                        },
                        new Transaction
                        {
                            Id = "2",
                            Date = DateTime.Now.Date,
                            NF = "123456780",
                            PartnerName = "C.Vale Fidelidade",
                            Value = 249.9M
                        },
                        new Transaction
                        {
                            Id = "3",
                            Date = DateTime.Now.Date.AddDays(-1),
                            NF = "123456781",
                            PartnerName = "C.Vale Fidelidade",
                            PointsRedeemed = 500,
                            Value = 249.9M
                        },
                        new Transaction
                        {
                            Id = "4",
                            Date = DateTime.Now.Date.AddDays(-2),
                            NF = "123456783",
                            PartnerName = "C.Vale Fidelidade",
                            PointsRedeemed = 500,
                            Value = 229.9M
                        },
                    };
                    break;
                default:
                    break;
            }

            BusyLoader.SetIsLoading(false);
        }

        public async Task PopulatePeriodItemsList()
        {
            var currentYear = DateTime.Now;
            FilterPeriodItemList = PeriodItem.MonthsBetween(currentYear.Year, currentYear.AddYears(-3), currentYear.AddYears(3)).ToList();
            SelectedItemIndex = await GetSelectedIndex(currentYear.Month, currentYear.Year);
            var s = SelectedItemIndex;
        }

        public async Task<int> GetSelectedIndex(int month, int year)
        {
            return FilterPeriodItemList.Select((x, y) => new { Item = x, Index = y }).First(x => x.Item.Month == month && x.Item.Year == year).Index;
        }

        #region Commands
        public Command<Transaction> ShowPopupFilterCommand => new Command<Transaction>(async (x) =>
        {
            DataTemplate templateView;
            Label popupContent;
            SfPopupLayout popupLayout;

            popupLayout = new SfPopupLayout();
            templateView = new DataTemplate(() =>
            {
                popupContent = new Label();
                popupContent.Text = "This is the Customized view for SfPopupLayout";
                popupContent.BackgroundColor = Color.LightSkyBlue;
                popupContent.HorizontalTextAlignment = TextAlignment.Center;
                return popupContent;
            });

            // Adding ContentTemplate of the SfPopupLayout
            popupLayout.PopupView.ContentTemplate = templateView;
            popupLayout.PopupView.ShowFooter = false;
            popupLayout.PopupView.ShowHeader = false;

            popupLayout.Show();
        });

        #endregion

        #region Bindings

        private List<PeriodItem> _filterPeriodItemList = new List<PeriodItem> { };
        public List<PeriodItem> FilterPeriodItemList
        {
            get { return _filterPeriodItemList; }
            set { SetProperty(ref _filterPeriodItemList, value); }
        }
        
        private List<Transaction> _transactions = new List<Transaction> { };
        public List<Transaction> Transactions
        {
            get { return _transactions; }
            set { SetProperty(ref _transactions, value); }
        }

        private int _selectedItemIndex;
        public int SelectedItemIndex
        {
            get { return _selectedItemIndex; }
            set { SetProperty(ref _selectedItemIndex, value); }
        }

        private int _selectedTab = 0;
        public int SelectedTab
        {
            get { return _selectedTab; }
            set { SetProperty(ref _selectedTab, value); }
        }

        #endregion
    }

    public class PeriodItem
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public string Label { get; set; }

        public static IEnumerable<PeriodItem> MonthsBetween(
            int currentYear,
            DateTime startDate,
            DateTime endDate)
        {
            DateTime iterator;
            DateTime limit;

            if (endDate > startDate)
            {
                iterator = new DateTime(startDate.Year, startDate.Month, 1);
                limit = endDate;
            }
            else
            {
                iterator = new DateTime(endDate.Year, endDate.Month, 1);
                limit = startDate;
            }

            var dateTimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
            while (iterator <= limit)
            {
                yield return
                    new PeriodItem()
                    {
                        Month = iterator.Month,
                        Year = iterator.Year,
                        Label = iterator.Year == currentYear ?
                            dateTimeFormat.GetMonthName(iterator.Month) :
                            dateTimeFormat.GetMonthName(iterator.Month) + " " + iterator.Year
                    };

                iterator = iterator.AddMonths(1);
            }
        }
    }
}