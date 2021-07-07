using n_layer.DataAccess;
using n_layer.Mappers;
using System.Collections.Generic;
using System.Linq;

namespace n_layer.BusinessService
{
    class BusinessServiceImpl : IBusinessService
    {
        /// <summary>
        /// Добавление задачи
        /// </summary>
        private IDataAccsess<Target> _da;
        public void AddNewTarget(TargetBLL newTarget)
        {
            var list = _da.GetEntities();
            list.Add(TargetMapper.ToDAL(newTarget));
            _da.SaveEntities(list);
        }
        /// <summary>
        /// Удаление задачи
        /// </summary>
        /// <param name="targetToDelete"></param>
        public void DeleteTarget(TargetBLL targetToDelete)
        {
            var bllList = TargetMapper.ToBLLList(_da.GetEntities());

            bllList.RemoveAll(i => i.Id == targetToDelete.Id);
            _da.SaveEntities(TargetMapper.ToDALList(bllList));

        }
        /// <summary>
        /// Редактирование задачи
        /// </summary>
        /// <param name="editedTarget"></param>
        public void EditTarget(TargetBLL editedTarget)
        {
            var bllList = TargetMapper.ToBLLList(_da.GetEntities());
            bllList.RemoveAll(i => i.Id == editedTarget.Id);
            _da.SaveEntities(TargetMapper.ToDALList(bllList));
        }
        /// <summary>
        /// Поиск по id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TargetBLL GetTargetById(int id)
        {          
            var bllList = TargetMapper.ToBLLList(_da.GetEntities());
            return bllList.Single(i => i.Id == id);
        }
        /// <summary>
        /// Поиск по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public TargetBLL GetTargetByName(string name)
        {            
            var bllList = TargetMapper.ToBLLList(_da.GetEntities());
            return bllList.Single(i => i.Name == name);
        }
        /// <summary>
        /// Вернуть полный список задач
        /// </summary>
        /// <returns></returns>
        public List<TargetBLL> GetTodoList()
        {
            var bllList = TargetMapper.ToBLLList(_da.GetEntities());
            return bllList;
        }
        
    }
}
