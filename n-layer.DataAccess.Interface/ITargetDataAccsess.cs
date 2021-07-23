using n_layer.Entities;
using System.Collections.Generic;



namespace n_layer.DataAccess
{
    public interface  ITargetDataAccsess
    {
        IEnumerable<Target> GetEntities();
        void SaveEntities(IEnumerable<Target> newdata);

    }
}
