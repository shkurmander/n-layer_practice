using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.BusinessService
{
    public interface IBusinessService
    {
        public IList<ITargetBLL> GetTodoList();
        public ITargetBLL GetTargetById(int id);
        public ITargetBLL GetTargetByName(string name);
        public void AddNewTarget(ITargetBLL newTarget);
        public void EditTarget(ITargetBLL editedTarget);
        public void DeleteTarget(ITargetBLL targetToDelete);


    }
}
