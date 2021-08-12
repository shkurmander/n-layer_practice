
using System;
using System.Collections.Generic;

namespace n_layer.Cache
{
    public class MemoryCache : ICache
    {


		private Dictionary<string, object> cache = new Dictionary<string, object>();

		public T GetOrCreate<T>(string key, Func<T> func)
		{
			if (cache.TryGetValue(key, out var value))
			{
				return (T)value;
			}
			else
			{
				var obj = func.Invoke();
				cache.Add(key, obj);
				return obj;
			}
		}

		public void Reset(string key)
		{
			cache.Remove(key);
		}
	}
}
