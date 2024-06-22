using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.App
{
    internal class Cache
    {
        private Dictionary<string, object> cache = new();
        public void AddCache(string key, object value)
        {
            
            cache.Add(key, value);
        }

        public object GetCache(string key)
        {
            return cache[key];
        }
    }

    public class CacheGeneric<T, T2> where T : class
    {
        private Dictionary<T, T2> cache = new();

        public void AddCache(T key, T2 value)
        {
            cache.Add(key, value);
        }

        public T2 GetCache(T key)
        {
            return cache[key];
        }
    }
}
