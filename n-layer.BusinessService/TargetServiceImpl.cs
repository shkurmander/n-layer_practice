using n_layer.Entities;
using n_layer.DataAccess;

using System.Collections.Generic;
using System.Linq;

namespace n_layer.BusinessService
{
    public class TargetServiceImpl : ITargetService
    {
       
        private ITargetDataAccsess _da;
        public TargetServiceImpl()
        {
            _da = new TargetDataAccsessImpl();
        }
        public TargetServiceImpl(ITargetDataAccsess da)
        {
            _da = da;
        }
        /// <summary>
        /// Добавление задачи
        /// </summary>
        public void AddNewTarget(Target newTarget)
        {
            var list = _da.GetEntities();
            //newTarget.Id = Helpers.getNewId();
            list.Add(newTarget);
            _da.SaveEntities(list);
        }
        /// <summary>
        /// Удаление задачи
        /// </summary>
        /// <param name="targetToDelete"></param>
        public void DeleteTarget(int id)
        {
            var bllList = _da.GetEntities();

            bllList.RemoveAll(i => i.Id == id);
            _da.SaveEntities(bllList);

        }
        /// <summary>
        /// Редактирование задачи
        /// </summary>
        /// <param name="editedTarget"></param>
        public void EditTarget(Target editedTarget)
        {
            var bllList =_da.GetEntities();
            bllList.RemoveAll(i => i.Id == editedTarget.Id);
            _da.SaveEntities(bllList);
        }
        /// <summary>
        /// Поиск по id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Target GetTargetById(int id)
        {          
            var bllList = _da.GetEntities();
            return bllList.Single(i => i.Id == id);
        }
        /// <summary>
        /// Поиск по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Target> GetTargetByName(string name)
        {            
            var bllList = _da.GetEntities();

            return bllList.Where(i => i.Name.Contains(name)).ToList();
        }
        /// <summary>
        /// Вернуть полный список задач
        /// </summary>
        /// <returns></returns>
        public List<Target> GetAll()
        {
            var bllList = _da.GetEntities();
            return bllList;
        }

        
    }
}
