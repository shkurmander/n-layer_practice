using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.BusinessService
{
    public interface IBusinessService
    {
        public IList<TargetBLL> GetTodoList();
        public TargetBLL GetTargetById(int id);
        public TargetBLL GetTargetByName(string name);
        public void AddNewTarget(TargetBLL newTarget);
        public void EditTarget(TargetBLL editedTarget);
        public void DeleteTarget(TargetBLL targetToDelete);


    }
}
