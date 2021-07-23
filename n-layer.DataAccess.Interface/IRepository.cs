using n_layer.Entities;
using System.Collections.Generic;



namespace n_layer.DataAccess
{
    public interface  IRepository<T> where T : class
    {
       
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> Find(string name);
        T Find(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Save(); 

    }
}
