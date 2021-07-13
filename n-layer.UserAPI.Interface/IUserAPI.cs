using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.UserAPI.Interface
{
    public interface IUserAPI
    {
        public List<TargetPL> GetTodoList();
        public TargetPL GetTargetById(int id);
        public List<TargetPL> GetTargetByName(string name);
        public void AddNewTarget(string name, int priority, string text);
        public void EditTarget(TargetPL targetToEdit);
        public void DeleteTarget(int id);
    }
}
