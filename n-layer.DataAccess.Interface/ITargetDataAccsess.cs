using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.DataAccess
{
    public interface  ITargetDataAccsess
    {
        public List<TargetDAL> GetEntities();
        public void SaveEntities(List<TargetDAL> newdata);

    }
}
