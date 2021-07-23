
using n_layer.Entities;
using System.Collections.Generic;


namespace n_layer.DataAccess
{
    public class TargetDataAccsessImpl : ITargetDataAccsess
    {
        private IDataRepository<Target> _repo;        
        public TargetDataAccsessImpl()
        {
            _repo = new FileDataRepository<Target>("todolist.dat");
            
        }
        public List<Target> GetEntities()
        {            
            return _repo.Load();
        }        

        public  void SaveEntities(List<Target> newdata)
        {
            _repo.Save(newdata);
        }      
        

    }
}
