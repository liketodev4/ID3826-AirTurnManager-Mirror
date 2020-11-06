using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace AirTurnManager.UI.Helpers
{
    public class BooleanConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var test = (bool?)value;
            var result = bool.Parse((string)parameter);

            if (test == result)
            {
                return true;
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            var result = bool.Parse((string)parameter);
            return result;
        }
    }
}
