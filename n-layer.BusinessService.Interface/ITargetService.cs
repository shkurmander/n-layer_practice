using System.Collections.Generic;


namespace n_layer.BusinessService
{
    public interface ITargetService
    {
        public List<TargetBLL> GetTodoList();
        public TargetBLL GetTargetById(int id);
        public List<TargetBLL> GetTargetByName(string name);
        public void AddNewTarget(TargetBLL newTarget);
        public void EditTarget(TargetBLL editedTarget);
        public void DeleteTarget(int id);        

    }
}
