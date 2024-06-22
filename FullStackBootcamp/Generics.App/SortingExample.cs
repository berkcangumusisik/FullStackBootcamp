using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.App
{
    public class SortingExample<T>
    {
        public List<T> Sort(List<T> list)
        {
            return list.OrderBy(x => x).ToList();

        }
    }

    public class SortingExample2<T,T2> where T : IEnumerable<T2>
    {
        public List<T2> Sort(T list)
        {
            var a = list.OrderBy(x => x).ToList();
            return a;
        }
    }
}
