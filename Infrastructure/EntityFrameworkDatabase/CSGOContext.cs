namespace Infrastructure.EntityFrameworkDatabase
{
    using Core.Entities;
    using Microsoft.EntityFrameworkCore;

    public class CSGOContext : DbContext
    {
        public CSGOContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Weapon> Weapons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=localhost;Initial Catalog=csgo;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Weapon>().HasKey(sc => new { sc.Id });
            base.OnModelCreating(builder);
        }
    }
}
