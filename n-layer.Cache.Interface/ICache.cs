﻿
using n_layer.BusinessService;
using n_layer.Common;
using System.Collections.Generic;

namespace n_layer.Cache
{
    public interface ICache
    {
        public void AddToCache(List<Target> targetList);
        public List<Target> GetFromCache();

    }

    
}
