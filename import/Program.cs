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

            var service = serviceProvider.GetService<IRepository>();
            var weaponList = FileReader.ReadFileWeapons();
            var weaponsImageList = FileReader.ReadFileWeaponsImage();

            foreach (var weapon in weaponList)
            {
                service.Add(weapon);
            }

            foreach (var weaponImage in weaponsImageList)
            {
                service.Add(weaponImage);
            }

        }
    }
}
