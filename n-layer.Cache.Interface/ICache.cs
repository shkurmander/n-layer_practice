
using n_layer.BusinessService;
using System.Collections.Generic;

namespace n_layer.Cache
{
    public interface ICache
    {
        public void AddToCache(List<TargetBLL>);
        public List<TargetBLL> GetFromCache();

    }

    
}
