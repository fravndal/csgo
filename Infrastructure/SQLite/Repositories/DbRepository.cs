namespace Infrastructure.SQLite.Repositories
{
    using Core.Entities;
    using Core.Interfaces;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;
    using System.Linq;

    public class DbRepository : IRepository
    {
        private readonly CSGOContext _dbContext;
        private readonly ILogger<DbRepository> _logger;

        public DbRepository(CSGOContext dbContext, ILoggerFactory loggerFactory)
        {
            _dbContext = dbContext;
            _logger = loggerFactory.CreateLogger<DbRepository>();
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
            _logger.LogInformation($"{entity}");
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }
    }
}
