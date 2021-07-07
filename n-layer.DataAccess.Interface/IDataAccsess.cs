using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.DataAccess
{
    public interface  IDataAccsess<T> 
    {
        public IList<T> GetEntities();
        public void SaveEntities(IList<T> newdata);

    }
}
