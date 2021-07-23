using n_layer.Common;
using System.Collections.Generic;



namespace n_layer.DataAccess
{
    public interface  ITargetDataAccsess
    {
        public List<Target> GetEntities();
        public void SaveEntities(List<Target> newdata);

    }
}
