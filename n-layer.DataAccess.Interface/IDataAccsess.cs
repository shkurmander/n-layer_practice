using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.DataAccess
{
    public interface  IDataAccsess
    {
        public List<Target> GetEntities();
        public void SaveEntities(List<Target> newdata);

    }
}
