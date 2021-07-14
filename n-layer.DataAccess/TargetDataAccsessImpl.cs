using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.DataAccess
{
    public class TargetDataAccsessImpl : ITargetDataAccsess
    {
        private IDataRepository<TargetDAL> _repo;        
        public TargetDataAccsessImpl()
        {
            _repo = new FileDataRepository<TargetDAL>("todolist.dat");
            
        }
        public List<TargetDAL> GetEntities()
        {            
            return _repo.Load();
        }        

        public  void SaveEntities(List<TargetDAL> newdata)
        {
            _repo.Save(newdata);
        }      
        

    }
}
