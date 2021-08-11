using n_layer.BusinessService;
using n_layer.DataAccess;
using n_layer.Entities;
using n_layer.Entities.Configuration;
using System;

namespace n_layer.IoC
{
    public class DependencyResolver
    {
        private ConfigurationDAL _confgigDAL;
        private IRepository<Target> _targetRepo;

        public DependencyResolver(ConfigurationDAL config)
        {
            _confgigDAL = config;
        }
        
        

        public IRepository<Target>  GetRepository(ConfigurationDAL config)
        {
            switch (config.Type)
            {
                case TypeOfDao.File:
                    return new TargetFileRepository(config.FilePath);
                    
                case TypeOfDao.MSSQL:
                    return new TargetSQLRepository(config.DbConnection);
                    
                case TypeOfDao.Memory:
                    return new TargetMemoryRepository();
                    return new TargetMemoryRepository();
                default:
                    throw new ArgumentException("Некорректный параметр конфигурации хранилища");                   
            }

        }
        private  ITargetService targetService { get; } 

        

    }

}
