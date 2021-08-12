using n_layer.BusinessService;
using n_layer.UserAPI.Interface;
using System.Collections.Generic;
using System.Linq;
using n_layer.Entities;
using n_layer.DataAccess;

namespace n_layer.UserAPI
{
    public class TargetUserAPI : IUserAPI
    {
        private ITargetService _bl;
        
        public TargetUserAPI(ITargetService bl)
        {
            _bl = bl;
        }
        public void AddNewTarget(Target target)
        {            
            _bl.AddNewTarget(target);
        }

        public void DeleteTarget(int id)
        {
            _bl.DeleteTarget(id);
        }

        public void EditTarget(Target editedTarget)
        {
            _bl.EditTarget(editedTarget);
        }

        public List<Target> GetSortByPriority()
        {
            
             var unsorted = GetAll();
             return unsorted.OrderBy(t => t.Priority).ToList();
           
        }

        public Target GetTargetById(int id)
        {
            return _bl.GetTargetById(id);
        }

        public List<Target> GetTargetByName(string name)
        {
            return _bl.GetTargetByName(name).ToList();
        }

        public List<Target> GetAll()
        {
            return _bl.GetAll().ToList();
        }
    }
}
