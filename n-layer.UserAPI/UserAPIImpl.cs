using n_layer.BusinessService;
using n_layer.UserAPI.Interface;
using n_layer.Mappers;
using System.Collections.Generic;

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
        public void AddNewTarget(TargetPL target)
        {            
            _bl.AddNewTarget(TargetMapper.PLToBLL(target));
        }

        public void DeleteTarget(int id)
        {
            _bl.DeleteTarget(id);
        }

        public void EditTarget(TargetPL editedTarget)
        {
            _bl.EditTarget(TargetMapper.PLToBLL(editedTarget));
        }

        public TargetPL GetTargetById(int id)
        {
            return TargetMapper.BLLToPL(_bl.GetTargetById(id));
        }

        public List<TargetPL> GetTargetByName(string name)
        {
            return TargetMapper.BLLToPLList(_bl.GetTargetByName(name));
        }

        public List<TargetPL> GetTodoList()
        {
            return TargetMapper.BLLToPLList(_bl.GetTodoList());
        }
    }
}
