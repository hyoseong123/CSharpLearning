using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BookStoreWPF_HHS
{
    class TypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int intType = (int)value;
            string stringType = "";

            switch (intType)
            {
                case 1:
                    stringType = "Comic";
                    break;
                case 2:
                    stringType = "Novel";
                    break;
                default:
                    break;
            }

            return stringType;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
