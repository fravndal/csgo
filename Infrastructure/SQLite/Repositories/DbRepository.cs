namespace Infrastructure.SQLite.Repositories
{
    using Core.Entities;
    using Core.Interfaces;
    using System.Collections.Generic;
    using System.Linq;

    public class DbRepository : IRepository
    {
        private readonly CSGOContext _dbContext;
        

        public DbRepository(CSGOContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T GetById<T>(int id) where T : BaseEntity
        {
            return _dbContext.Set<T>().SingleOrDefault(e => e.Id == id);
        }

        public List<T> List<T>() where T : BaseEntity
        {
            return _dbContext.Set<T>().ToList();
        }

        public void Add<T>(T entity) where T : BaseEntity
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }
    }
}
