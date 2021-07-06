using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.BusinessService.Cache
{
    public interface ICache
    {
        public void AddToCache();

        public INotify AddToCache();
    }
}
