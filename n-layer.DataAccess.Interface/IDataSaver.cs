using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.DataAccess
{
    public interface IDataRepository <T>
    {
        
        public void Save(IList<T> data);
        public IList<T> Load();

    }
}
