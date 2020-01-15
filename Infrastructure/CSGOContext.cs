using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    class CSGOContext : DbContext
    {
        public DbSet<Weapon> Weapons { get; set; }

        public CSGOContext(DbContextOptions<CSGOContext> options) : base(options)
        {
        }

        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasSequence<int>("seq", schema: "csgo").StartsAt(0).IncrementsBy(1);
            modelBuilder.Entity<Weapon>().HasKey(sc => new { sc.Id });

            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
