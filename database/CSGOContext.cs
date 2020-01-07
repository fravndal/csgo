using entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace database
{
    public class CSGOContext : DbContext
    {
        public DbSet<Weapon> Weapons { get; set; }

        //public CSGOContext(DbContextOptions<CSGOContext> options) : base(options)
        //{
            
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=localhost;Initial Catalog=csgo;Integrated Security=True;");
        }

        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("seq", schema: "csgo").StartsAt(0).IncrementsBy(1);
            modelBuilder.Entity<Weapon>().HasKey(sc => new { sc.Id });
        }
        #endregion
    }
}
