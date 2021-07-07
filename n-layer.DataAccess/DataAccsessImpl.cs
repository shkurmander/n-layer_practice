﻿using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.DataAccess
{
    class DataAccsessImpl<T> : IDataAccsess<T> 
    {
        private IDataRepository<T> _repo;
        public IList<T> GetEntities()
        {            
            return _repo.Load();
        }        

        public  void SaveEntities(IList<T> newdata)
        {
            _repo.Save(newdata);
        }
        public DataAccsessImpl()
        {
            _repo = new FileDataRepository<T>("todolist.dat");
        }
    }
}
