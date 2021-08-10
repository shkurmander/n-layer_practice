using n_layer.BusinessService;
using n_layer.DataAccess;
using n_layer.Entities.Configuration;
using System;

namespace n_layer.IoC
{
    public class DependencyResolver
    {
        private ITargetRepository _targetRepo;

        public DependencyResolver(ConfigurationDAL config)
        {

        }
        private static ITargetRepository TargetFileRepository { get;  } = new TargetFileRepository();
        public static ITargetService targetService { get; } = new TargetService();
    }
}
