using System;
using System.Globalization;
using System.Windows.Data;

namespace LCARSToolkit.Controls
{
    [ValueConversion(typeof(string), typeof(string))]
    public class ToUpperConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value is not string text) ? value : text.ToUpper();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}