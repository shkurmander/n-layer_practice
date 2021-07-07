
using n_layer.DataAccess;
using System;
using System.Collections.Generic;


namespace n_layer.BusinessService
{
    class BusinessServiceImpl : IBusinessService
    {
               
        private IDataAccsess<Target> _da;
        public void AddNewTarget(TargetBLL newTarget)
        {
            var list = _da.GetEntities();
            var data = TargetMapper
        }

        public void DeleteTarget(TargetBLL targetToDelete)
        {
            throw new NotImplementedException();
        }

        public void EditTarget(TargetBLL editedTarget)
        {
            throw new NotImplementedException();
        }

        public TargetBLL GetTargetById(int id)
        {
            throw new NotImplementedException();
        }

        public TargetBLL GetTargetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IList<TargetBLL> GetTodoList()
        {
            throw new NotImplementedException();
        }
    }
}
