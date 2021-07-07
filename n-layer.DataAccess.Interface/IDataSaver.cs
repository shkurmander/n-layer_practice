using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.DataAccess
{
    public interface IDataRepository <T>
    {
        
        public void Save(List<T> data);
        public List<T> Load();

    }
}
