using n_layer.Entities;
using System.Collections.Generic;
using System.Linq;

namespace n_layer.DataAccess
{
    public class TargetSQLRepository : ITargetRepository
    {
        private AppDbContext _db;
        public TargetSQLRepository(string dbconnection)
        {
            _db = new AppDbContext(dbconnection);
        }
        public void Create(Target item)
        {
            _db.Add(item);
            Save();
        }

        public void Delete(int id)
        {
            var item = _db.Targets.Find(id);
            _db.Targets.Remove(item);
            Save();

        }

        public IEnumerable<Target> Find(string name)
        {
            return _db.Targets.Where(t => t.Name.Contains(name)).ToList();
          
        }

        public Target Get(int id)
        {
            try
            {
                return _db.Targets.Where(t => t.Id == id).Single();
            }
            catch (System.ArgumentNullException)
            {
                return null;
            }
               
            
        }

        public IEnumerable<Target> GetAll()
        {
            return _db.Targets.ToList();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Target item)
        {

            _db.Find<Target>(item);
            Save();
            
        }
    }
}
