using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.DataAccess
{
    public class DataAccsessImpl : IDataAccsess
    {
        private IDataRepository<Target> _repo;        
        public DataAccsessImpl()
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
