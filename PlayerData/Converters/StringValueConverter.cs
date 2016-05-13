using PlayerData.Classes;
using System;
using System.Globalization;
using System.Windows.Data;

namespace PlayerData.Converters
{
    public class StringValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int _index;

            if (int.TryParse((string)parameter, out _index))
            {
                if (_index >= 0 && _index < CommonData.formats.Length)
                {
                    string _format = CommonData.formats[_index];

                    return string.Format(culture, _format, value);
                }
            }

            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
