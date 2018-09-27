using Syncfusion.DataSource;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinFormsAcordeonListView
{
    public partial class AcordeonListView : ContentPage
    {
        public AcordeonListView()
        {
            InitializeComponent();

            Customers.DataSource.GroupDescriptors.Add(new GroupDescriptor(null, customer => customer));
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