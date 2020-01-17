using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.SQL
{
    public class SqlContextFactory : IDesignTimeDbContextFactory<SqlContext>
    {
        public SqlContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SqlContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=CSGO;Integrated Security=True;");

            return new SqlContext(optionsBuilder.Options);
        }

        //public static SqlContext GetDbContext()
        //{
        //    var services = new ServiceCollection();


        //    services.AddDbContext<SqlContext>(options => options.UseSqlServer(
        //            "Data Source=localhost;Initial Catalog=CSGO;Integrated Security=True;"
        //            ));
        //    services.AddDbContext<SqlContext>(options => options.UseSqlServer("IMDBDb"));
        //    var serviceProvider = services.BuildServiceProvider();
        //    return _context = serviceProvider.GetService<SqlContext>();
        //}
    }
}
