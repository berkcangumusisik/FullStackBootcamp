using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Homework1
{
    public class Convertor
    {
        public static List<T> ConvertTo<T>(List<string> input, Func<string, T> converter)
        {
            List<T> result = new List<T>();
            foreach (var item in input)
            {
                result.Add(converter(item));
            }
            return result;
        }
    }
}
