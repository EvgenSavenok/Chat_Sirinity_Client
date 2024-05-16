﻿using System.Globalization;
using System.Windows;

namespace Chat_Sirinity_Client.Convertors;

public class SentByMeToBackgroundConverter : BaseValueConverter<SentByMeToBackgroundConverter>
{
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (bool)value ? Application.Current.FindResource("VeryLightBlueBrush") : Application.Current.FindResource("WhiteBrush");
    }

    public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new Exception();
    }
}
