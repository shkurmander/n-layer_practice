using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.DataAccess
{
    public interface IDataRepository <T>
    {
        
        public void Save(IEnumerable<T> data);
        public IEnumerable<T> Load();

    }
}
