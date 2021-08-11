using Microsoft.Extensions.Configuration;
using n_layer.Entities.Configuration;
using n_layer.IoC;
using n_layer.UserAPI;
using System;
using System.IO;

namespace n_layer.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();
            var configDal = configuration.GetSection("configurationDal").Get<ConfigurationDAL>();
            var container = new DependencyResolver(configDal);
            


            var ui = new UIRepo();
            ui.DrawMainMenu();
            Console.ReadKey();
        }
    }
}
