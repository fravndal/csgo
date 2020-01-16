using Core.Interfaces;
using Infrastructure.SQLite.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Import
{
    
    class Program
    {
        static void Main(string[] args)
        {

            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<IRepository, DbRepository>()
                .BuildServiceProvider();

            serviceProvider
                .GetService<ILoggerFactory>();
              

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();

            logger.LogDebug("Starting application");

            var service = serviceProvider.GetService<IRepository>();
            var weaponList = FileReader.ReadFile();
            
            foreach(var weapon in weaponList)
            {
                service.Add(weapon);
            }
        }
    }
}
