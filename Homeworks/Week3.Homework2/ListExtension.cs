using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Homework2
{
    public static class ListExtension
    {
        public static void ReverseOrder<T>(this List<T> list)
        {
            list.Reverse();
        }
    }
}
