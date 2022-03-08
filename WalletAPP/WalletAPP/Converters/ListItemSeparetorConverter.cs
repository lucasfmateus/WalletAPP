using WalletAPP.Models;
using WalletAPP.Views.Parts;
using Syncfusion.DataSource.Extensions;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using System.Linq;

namespace WalletAPP.Converters
{
    public class ListItemSeparetorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            var listView = parameter as StackLayout;

            var Vm = listView.BindingContext as DashboardViewModel;

            var items = Vm.Funds;

            if (value == null)
                return false;

            if(items.Count == 1)
                return false;

            return items[items.Count - 1] == value;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class SfListSeparetorConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value == null)
            {
                return false;
            }

            var itemData = value as Transaction;

            var items = GetGroup(itemData, parameter as SfListView);
            
            if (items.Count == 1)
            {
                return false;
            }
           
            return items.LastOrDefault().Id != itemData.Id;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private List<Transaction> GetGroup(Transaction itemData, SfListView list)
        {
            foreach (var item in list.DataSource.Groups)
            {
                var items = item.Items.ToList<Transaction>().ToList();

                if (items.Any(x => x.Id == itemData.Id))
                {
                    return items;
                }
            }

            return list.DataSource.DisplayItems.ToList<Transaction>().ToList();
        }
    }
}
