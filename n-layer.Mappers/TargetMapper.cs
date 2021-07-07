using n_layer.BusinessService;
using n_layer.DataAccess;
using System.Collections.Generic;

namespace n_layer.Mappers
{
    public static class TargetMapper
    {
        public static Target ToDAL(TargetBLL bllObj)
        {
            return new Target
            {
                Id = bllObj.Id,
                Name = bllObj.Name,
                Priority = bllObj.Priority,
                Text = bllObj.Text,
                State = bllObj.State
            };
        }
        public static TargetBLL ToBLL(Target dalObj)
        {
            return new TargetBLL
            {
                Id = dalObj.Id,
                Name = dalObj.Name,
                Priority = dalObj.Priority,
                Text = dalObj.Text,
                State = dalObj.State
            };
        }

        public static List<Target> ToDALList(List<TargetBLL> bllList)
        {
            var dalList = new List<Target>();
            foreach (var item in bllList)
            {
                dalList.Add(
                    new Target
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Priority = item.Priority,
                        Text = item.Text,
                        State = item.State
                    });
            }
            return dalList;
        }
        public static List<TargetBLL> ToBLLList(List<Target> dalList)
        {
            var bllList = new List<TargetBLL>();
            foreach (var item in dalList)
            {
                bllList.Add(
                    new TargetBLL
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Priority = item.Priority,
                        Text = item.Text,
                        State = item.State
                    });
            }
            return bllList;
        }
    }
}
