using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.DataAccess
{
    class DataAccsessImpl<T> : IDataAccsess<T> 
    {
        public IList<T> GetEntities()
        {
            throw new NotImplementedException();
        }

        public IList<ITarget> SaveEntities(IList<T> newdata)
        {
            throw new NotImplementedException();
        }
    }
}
