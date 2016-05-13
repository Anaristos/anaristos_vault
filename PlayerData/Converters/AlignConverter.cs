using PlayerData.Classes;
using System;
using System.Globalization;
using System.Windows.Data;

namespace PlayerData.Converters
{
    public class AlignConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            long _value = Math.Abs((long) value);

            return string.Format(culture, CommonData.formats[2], _value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
