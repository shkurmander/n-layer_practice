
using System;


namespace n_layer.Cache
{
    public interface ICache
    {
        T GetOrCreate<T>(string key, Func<T> func);

        void Reset(string key);
    }
}

    

