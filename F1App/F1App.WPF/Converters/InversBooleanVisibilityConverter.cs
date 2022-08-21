using System;
using System.Windows;
using System.Windows.Data;
using CalcBinding;

namespace F1App.WPF.Converters
{
    [ValueConversion(typeof(Visibility), typeof(Visibility))]
    public class InverseBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            if (targetType != typeof(Visibility)) throw new ArgumentException();
            BoolToVisibilityConverter conv = new BoolToVisibilityConverter(FalseToVisibility.Hidden);
            return conv.Convert(!(bool)value, targetType, parameter, culture);
        }
        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}