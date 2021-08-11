using n_layer.BusinessService;
using n_layer.DataAccess;
using n_layer.Entities.Configuration;
using System;

namespace n_layer.IoC
{
    public class DependencyResolver
    {
        private ConfigurationDAL _confgigDAL;
        private ITargetRepository _targetRepo;

        public DependencyResolver(ConfigurationDAL config)
        {
            _confgigDAL = config;
        }
        
        

        private  ITargetRepository TargetFileRepository { get;  }
        private  ITargetService targetService { get; } 

        

    }

}
