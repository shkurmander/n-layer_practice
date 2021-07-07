using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.DataAccess
{
    public interface  IDataAccsess<T> 
    {
        public List<T> GetEntities();
        public void SaveEntities(List<T> newdata);

    }
}
