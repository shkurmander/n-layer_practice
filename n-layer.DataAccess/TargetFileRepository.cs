
using n_layer.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace n_layer.DataAccess
{
    public class TargetFileRepository : ITargetRepository
    {
        private FileContext _db;
        public TargetFileRepository(string path)
        {
            _db = new FileContext(path);
        }
        public void Create(Target item)
        {
            item.Id = GetId();
            _db.Targets.Add(item);
            Save();
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

       
        public Target Get(int id)
        {
            return  GetAll().Where(t => t.Id == id).Single();
            
        }

        public IEnumerable<Target> GetAll()
        {
            return _db.Targets;
        }

        public void Save()
        {
            Console.WriteLine($"Сохраняем данные в файл:\n");

            using (var sw = new StreamWriter(_db.FilePath))
            {
                string json = JsonConvert.SerializeObject(_db.Targets, Formatting.Indented);
                sw.Write(json);
            }

        }

        public void Update(Target item)
        {
            throw new System.NotImplementedException();
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
