using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Homework1
{
    public class DataStore<T>
    {
        private List<T> _data = new List<T>();
        public void Add(T item)
        {
            _data.Add(item);
        }
        public T Get(int index)
        {
            return _data[index];
        }

        public void DisplayAll()
        {
            foreach (var item in _data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
