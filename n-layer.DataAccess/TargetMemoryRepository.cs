using n_layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace n_layer.DataAccess
{
    public class TargetMemoryRepository : ITargetRepository
    {
        private MemoryContext _db;
        public TargetMemoryRepository()
        {
            _db = new MemoryContext();
        }

        public void Create(Target item)
        {
            item.Id = GetId();
            _db.Targets.Add(item);
        }

        public void Delete(int id)
        {
            var item = Get(id);
            _db.Targets.Remove(item);
        }

        public IEnumerable<Target> Find(string name)
        {
            return GetAll().Where(item => item.Name.ToLower().Contains(name.ToLower()));
        }      

        public void Save()
        {
            throw new NotImplementedException("Этот метод в MemoryDB вызываться не должен");
        }

        public void Update(Target item)
        {
            throw new NotImplementedException();
        }
        public Target Get(int id)
        {
            return GetAll().Where(t => t.Id == id).Single();

        }

        public IEnumerable<Target> GetAll()
        {
            return _db.Targets;
        }

        private int GetId()
        {
            if (_db.Targets.Count == 0)
            {
                return 1;
            }
            return _db.Targets.Max(item => item.Id) + 1;
        }
    }
}
