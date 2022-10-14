using NetCore_DemoConverterParameter.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace NetCore_DemoConverterParameter.Converters
{
    public class BooleanToGenderConverter : IValueConverter
    {
        //ViewModel To View
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null)
                return Binding.DoNothing;

            if(value is Genres genre)
            {
                return genre.ToString() == (string)parameter;
            }

            return Binding.DoNothing;
        }

        //View To ViewModel
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is bool b && b)
            {
                return Enum.Parse(typeof(Genres), (string)parameter);
            }

            return Binding.DoNothing;
        }
    }
}
