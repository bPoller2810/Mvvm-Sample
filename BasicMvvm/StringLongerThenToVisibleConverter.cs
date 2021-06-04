using System;
using System.Globalization;
using Xamarin.Forms;

namespace BasicMvvm
{
    public class StringLongerThenToVisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not string str || parameter is not string parStr || !int.TryParse(parStr, out var par))
            {
                return false;
            }
            return str.Length > par;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
