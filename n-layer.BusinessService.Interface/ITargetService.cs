using System.Collections.Generic;


namespace n_layer.BusinessService
{
    public interface ITargetService
    {
        public List<TargetBLL> GetTodoList();
        public TargetBLL GetTargetById(int id);
        public TargetBLL GetTargetByName(string name);
        public void AddNewTarget(TargetBLL newTarget);
        public void EditTarget(TargetBLL editedTarget);
        public void DeleteTarget(TargetBLL targetToDelete);


    }
}
