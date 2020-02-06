﻿namespace Infrastructure.SQL.Repository
{
    using Core.Interfaces;
    using Microsoft.Extensions.Logging;
    using System.Linq;
    using System.Collections.Generic;
    using Core.Entities;
    using Microsoft.EntityFrameworkCore;

    public class WeaponRepository : IWeaponRepository
    {
        private readonly SqlContext _dbContext;

        public WeaponRepository(SqlContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Weapon GetWeaponBySlug(string slug)
        {
            return _dbContext.Weapons
                .Include(x => x.WeaponImage)
                .FirstOrDefault(z => z.Slug == slug);
        }

        public IEnumerable<Weapon> GetWeapons()
        {
            return _dbContext.Weapons
                .Include(x => x.WeaponImage);
        }



    }
}
