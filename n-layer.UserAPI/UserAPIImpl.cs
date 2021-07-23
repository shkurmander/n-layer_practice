using n_layer.BusinessService;
using n_layer.UserAPI.Interface;
using n_layer.Mappers;
using System.Collections.Generic;
using System.Linq;
using n_layer.Common;

namespace n_layer.UserAPI
{
    public class UserAPIImpl : IUserAPI
    {
        private ITargetService _bl;
        public UserAPIImpl()
        {
            _bl = new TargetServiceImpl();
        }
        public UserAPIImpl(ITargetService bl)
        {
            _bl = bl;
        }
        public void AddNewTarget(Target target)
        {            
            _bl.AddNewTarget(TargetMapper.PLToBLL(target));
        }

        public void DeleteTarget(int id)
        {
            _bl.DeleteTarget(id);
        }

        public void EditTarget(Target editedTarget)
        {
            _bl.EditTarget(TargetMapper.PLToBLL(editedTarget));
        }

        public List<Target> GetSortByPriority()
        {
            
             var unsorted = GetAll();
             return unsorted.OrderBy(t => t.Priority).ToList();
           
        }

        public Target GetTargetById(int id)
        {
            return TargetMapper.BLLToPL(_bl.GetTargetById(id));
        }

        public List<Target> GetTargetByName(string name)
        {
            return TargetMapper.BLLToPLList(_bl.GetTargetByName(name));
        }

        public List<Target> GetAll()
        {
            return TargetMapper.BLLToPLList(_bl.GetAll());
        }
    }
}
