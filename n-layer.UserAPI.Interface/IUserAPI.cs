using n_layer.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.UserAPI.Interface
{
    public interface IUserAPI
    {
        public List<Target> GetAll();
        public Target GetTargetById(int id);
        public List<Target> GetTargetByName(string name);
        public void AddNewTarget(Target target);
        public void EditTarget(Target targetToEdit);
        public void DeleteTarget(int id);
        public List<Target> GetSortByPriority();

    }
}
