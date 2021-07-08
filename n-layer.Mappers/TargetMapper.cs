using n_layer.BusinessService;
using n_layer.Common;
using n_layer.DataAccess;
using n_layer.UserAPI.Interface;
using System.Collections.Generic;

namespace n_layer.Mappers
{
    public static class TargetMapper
    {
        public static Target BLLToDAL(TargetBLL bllObj)
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
        public static TargetBLL DALToBLL(Target dalObj)
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

        public static List<Target> BLLToDALList(List<TargetBLL> bllList)
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
        public static List<TargetBLL> DALToBLLList(List<Target> dalList)
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
        public static TargetPL BLLToPL(TargetBLL bllObj)
        {
            return new TargetPL
            {
               
                Name = bllObj.Name,
                Priority = bllObj.Priority,
                Text = bllObj.Text,
                State = bllObj.State
            };
        }
        public static TargetBLL PLToBLL(TargetPL dalObj)
        {
            return new TargetBLL
            {                
                Name = dalObj.Name,
                Priority = dalObj.Priority,
                Text = dalObj.Text,
                State = dalObj.State
            };
        }

        public static List<TargetPL> BLLToPLList(List<TargetBLL> bllList)
        {
            var plList = new List<TargetPL>();
            foreach (var item in bllList)
            {
                plList.Add(
                    new TargetPL
                    {                        
                        Name = item.Name,
                        Priority = item.Priority,
                        Text = item.Text,
                        State = item.State
                    });
            }
            return plList;
        }
        public static List<TargetBLL> PLToBLLList(List<TargetPL> dalList)
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
