using n_layer.BusinessService;
using n_layer.Cache;
using n_layer.DataAccess;
using n_layer.Entities;
using n_layer.Entities.Configuration;
using System;

namespace n_layer.IoC
{
    public class DependencyResolver
    {

        private readonly ITargetRepository _targetDao;
        private readonly ICache _memCache;
        public ITargetService TargetService { get; }

        public DependencyResolver(ConfigurationDAL config)
        {            
            _targetDao = GetRepository(config);
            _memCache = new MemoryCache();
            TargetService = new TargetService(_targetDao, _memCache);
        }

       

        public ITargetRepository GetRepository(ConfigurationDAL config)
        {
            switch (config.Type)
            {
                case TypeOfDao.File:
                    return new TargetFileRepository(config.FilePath);
                    
                case TypeOfDao.MSSQL:
                    return new TargetSQLRepository(config.DbConnection);
                    
                case TypeOfDao.Memory:
                    return new TargetMemoryRepository();
                    
                default:
                    throw new ArgumentException("Некорректный параметр конфигурации хранилища");                   
            }

        }
       

        

    }

}
