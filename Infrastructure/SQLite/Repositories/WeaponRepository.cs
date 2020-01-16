namespace Infrastructure.SQLite.Repositories
{
    using Core.Entities;
    using Core.Interfaces;
    using System.Linq;
    using System.Collections.Generic;

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
