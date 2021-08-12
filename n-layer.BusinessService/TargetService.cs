using n_layer.Entities;
using n_layer.DataAccess;

using System.Collections.Generic;
using System.Linq;
using System;
using n_layer.Cache;

namespace n_layer.BusinessService
{
    public class TargetService : ITargetService
    {
       
        private readonly ITargetRepository _da;
        private readonly ICache _cache;
        private const string CACHE_KEY_JOB = "CACHE_KEY_JOB";

        public TargetService(ITargetRepository da, ICache cache)
        {
            _da = da;
            _cache = cache;
           
        }
        /// <summary>
        /// Добавление задачи
        /// </summary>
        public void AddNewTarget(Target newTarget)
        {
           
            _da.Create(newTarget);
            _cache.Reset(CACHE_KEY_JOB);
        }
        /// <summary>
        /// Удаление задачи
        /// </summary>
        /// <param name="targetToDelete"></param>
        public void DeleteTarget(int id)
        {
            _da.Delete(id);         

        }
        /// <summary>
        /// Редактирование задачи
        /// </summary>
        /// <param name="editedTarget"></param>
        public void EditTarget(Target editedTarget)
        {
            
        }
        /// <summary>
        /// Поиск по id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Target GetTargetById(int id)
        {
            return _da.Get(id);
            

        }
        /// <summary>
        /// Поиск по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IEnumerable<Target> GetTargetByName(string name)
        {
            return _da.Find(name);                                  //TODO Спросить где выполнять поиск
        }
        /// <summary>
        /// Вернуть полный список задач
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Target> GetAll()
        {
            return _cache.GetOrCreate(CACHE_KEY_JOB, () => _da.GetAll());
                
        }

        
    }
}
