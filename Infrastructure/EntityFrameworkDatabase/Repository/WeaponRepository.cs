namespace Infrastructure.EntityFrameworkDatabase.Repository
{
    using Microsoft.EntityFrameworkCore;
    using Core.Interfaces;
    using System.Linq;
    using System.Collections.Generic;
    using Core.Entities;

    public class WeaponRepository : IWeaponRepository
    {
        private readonly CSGOContext _dbContext;

        public WeaponRepository(CSGOContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T GetWeapon<T>(int id) where T : BaseEntity
        {
            return _dbContext.Set<T>().SingleOrDefault(e => e.Id == id);
        }

        public List<T> GetWeapons<T>() where T : BaseEntity
        {
            return _dbContext.Set<T>().ToList();
        }
    }
}
