namespace Import
{
    using Core.Interfaces;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using System.IO;
    using Microsoft.Data.SqlClient;
    using Infrastructure.SQL.Repository;
    using Infrastructure.SQL;

    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<SqlContext>()
                .AddSingleton<IRepository, SqlRepository>()
                .BuildServiceProvider();

            //var logger = serviceProvider.GetService<ILoggerFactory>()
            //    .CreateLogger<Program>();

            //logger.LogDebug("Starting application");

            var service = serviceProvider.GetService<IRepository>();
            var weaponList = FileReader.ReadFile();

            //var builder = new ConfigurationBuilder()
            //   .SetBasePath(Directory.GetCurrentDirectory())
            //   .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            //IConfigurationRoot configuration = builder.Build();

            //var connString = configuration.GetConnectionString("csgo");
                
            foreach (var weapon in weaponList)
            {
                service.Add(weapon);
            }
        }
    }
}
