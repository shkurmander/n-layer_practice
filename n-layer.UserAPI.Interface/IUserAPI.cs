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
        public void AddNewTarget(string name, int priority, string text);
        public void EditTarget();
        public void DeleteTarget(TargetPL targetToDelete);
    }
}
