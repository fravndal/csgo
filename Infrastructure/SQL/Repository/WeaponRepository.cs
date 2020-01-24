namespace Infrastructure.SQL.Repository
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

        public Weapon GetWeaponById(int id)
        {
            return _dbContext.Weapons
                .Include(x => x.WeaponImage)
                .ThenInclude(y => y.WeaponImageName)
                .FirstOrDefault(z => z.Id == id);
        }

        public IEnumerable<Weapon> GetWeapons()
        {
            return _dbContext.Weapons
                .Include(x => x.WeaponImage);
        }



    }
}
