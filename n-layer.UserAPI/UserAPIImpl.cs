using n_layer.BusinessService;
using n_layer.UserAPI.Interface;
using System;
using n_layer.Mappers;
using n_layer.Common;
using System.Collections.Generic;

namespace n_layer.UserAPI
{
    public class UserAPIImpl : IUserAPI
    {
        private ITargetService _bl;
        public UserAPIImpl(ITargetService bl)
        {
            _bl = bl;
        }
        public void AddNewTarget(string name, int priority, string text)
        {
            var target = new TargetPL()
            {
                Id = 0,
                Name = name,
                Priority = priority,
                Text = text
            };
            _bl.AddNewTarget(TargetMapper.PLToBLL(target));
        }

        public void DeleteTarget(string name)
        {
            throw new NotImplementedException();
        }

        public void EditTarget(TargetPL editedTarget)
        {
            throw new NotImplementedException();
        }

        public TargetPL GetTargetById(int id)
        {
            throw new NotImplementedException();
        }

        public TargetPL GetTargetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<TargetPL> GetTodoList()
        {
            throw new NotImplementedException();
        }
    }
}
