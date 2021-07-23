using n_layer.BusinessService;
using n_layer.Entities;
using n_layer.DataAccess;
using n_layer.UserAPI.Interface;
using System.Collections.Generic;

namespace n_layer.Mappers
{
    public static class TargetMapper
    {
        public static Target BLLToDAL(Target bllObj)
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
        public static Target DALToBLL(Target dalObj)
        {
            return new Target
            {
                Id = dalObj.Id,
                Name = dalObj.Name,
                Priority = dalObj.Priority,
                Text = dalObj.Text,
                State = dalObj.State
            };
        }

        public static List<Target> BLLToDALList(List<Target> bllList)
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
        public static List<Target> DALToBLLList(List<Target> dalList)
        {
            var bllList = new List<Target>();
            foreach (var item in dalList)
            {
                bllList.Add(
                    new Target
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
        public static Target BLLToPL(Target bllObj)
        {
            return new Target
            {
               
                Name = bllObj.Name,
                Priority = bllObj.Priority,
                Text = bllObj.Text,
                State = bllObj.State
            };
        }
        public static Target PLToBLL(Target dalObj)
        {
            return new Target
            {                
                Name = dalObj.Name,
                Priority = dalObj.Priority,
                Text = dalObj.Text,
                State = dalObj.State
            };
        }

        public static List<Target> BLLToPLList(List<Target> bllList)
        {
            var plList = new List<Target>();
            foreach (var item in bllList)
            {
                plList.Add(
                    new Target
                    {                        
                        Name = item.Name,
                        Priority = item.Priority,
                        Text = item.Text,
                        State = item.State
                    });
            }
            return plList;
        }
        public static List<Target> PLToBLLList(List<Target> dalList)
        {
            var bllList = new List<Target>();
            foreach (var item in dalList)
            {
                bllList.Add(
                    new Target
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
