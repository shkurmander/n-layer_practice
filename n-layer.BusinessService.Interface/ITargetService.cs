using n_layer.Entities;
using System.Collections.Generic;


namespace n_layer.BusinessService
{
    public interface ITargetService
    {
        public IEnumerable<Target> GetAll();
        public Target GetTargetById(int id);
        public IEnumerable<Target> GetTargetByName(string name);
        public void AddNewTarget(Target newTarget);
        public void EditTarget(Target editedTarget);
        public void DeleteTarget(int id);   
        

    }
}
