namespace Infrastructure.SQL.Repository
{
    using Core.Interfaces;
    using Microsoft.Extensions.Logging;
    using System.Linq;
    using System.Collections.Generic;
    using Core.Entities;

    public class SqlRepository : IRepository
    {
        private readonly SqlContext _dbContext;
        private readonly ILogger<SqlRepository> _logger;

        public SqlRepository(SqlContext dbContext, ILoggerFactory loggerFactory)
        {
            _dbContext = dbContext;
            _logger = loggerFactory.CreateLogger<SqlRepository>();
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
