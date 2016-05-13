using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace PlayerData.Converters
{
    public class DataColorConverterA : IValueConverter
    {
        private Int64 _value;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            _value = (Int64)value;

            if (_value > 100) return Brushes.DodgerBlue;
            else if (_value > 75) return Brushes.SpringGreen;
            else if (_value > 50) return Brushes.Yellow;
            else if (_value > 25) return Brushes.Orchid;
            else return Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
