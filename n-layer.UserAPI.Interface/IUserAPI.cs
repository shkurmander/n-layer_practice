using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.UserAPI.Interface
{
    public interface IUserAPI
    {
        public List<TargetPL> GetTodoList();
        public TargetPL GetTargetById(int id);
        public TargetPL GetTargetByName(string name);
        public void AddNewTarget(TargetPL newTarget);
        public void EditTarget(TargetPL editedTarget);
        public void DeleteTarget(TargetPL targetToDelete);
    }
}
