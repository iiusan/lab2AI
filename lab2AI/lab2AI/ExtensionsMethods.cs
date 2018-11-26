using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2AI
{
    public static class ExtensionsMethods
    {
        public static int ToInt32(this decimal value)
        {
            return Convert.ToInt32(value);
        }

        public static int ToInt32(this string value)
        {
            return Convert.ToInt32(value);
        }

        public static decimal ToDecimal(this string value)
        {
            try
            {
                return Convert.ToDecimal(value);
            }
            catch
            {
                return 0;
            }
        }


        public static double ToDouble(this decimal value)
        {
            return Convert.ToDouble(value);
        }

        public static decimal ToDecimal(this double value)
        {
            return Convert.ToDecimal(value);
        }
        public static List<int> ToIntList(this List<NrNeuroni> value)
        {
            List<int> list = new List<int>();
            foreach (var i in value)
                list.Add(i.GetNeuroni());
            return list;
        }
    }
}
