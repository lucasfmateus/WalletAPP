using System;
using System.Globalization;
using System.Linq;
using WalletAPP.Views.Parts;
using Xamarin.Forms;

namespace WalletAPP.Converters
{
    public class FundsValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
            {
                return null;
            }

            var par = parameter as StackLayout;

            var context = par.BindingContext as DashboardViewModel;

            var idValue = value as string;

            var item = context.Funds.Where(x => x.Id == idValue).FirstOrDefault();

            return item.Currency + " " + item.Value.ToString("F2");


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
