using Syncfusion.DataSource;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinFormsAcordeonListView
{
    public partial class AcordeonListView : ContentPage
	{
		public AcordeonListView ()
		{
			InitializeComponent ();

            CustomersGroup.KeySelector = (Customer) => Customer;
        }
    }

    public class ExapantionIndicatorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolValue && boolValue == true)              
                return "▲";

            return "▼";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}