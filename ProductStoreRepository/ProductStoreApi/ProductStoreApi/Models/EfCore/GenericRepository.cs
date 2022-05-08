using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStoreApi.Models.EfCore
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly DatabaseContext _dbContext;

        public GenericRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<TEntity> FindAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> FindById(int id)
        {
            return await _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(getId => getId.Id == id);
        }

        public async Task InsertModel(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateModel(int id, TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteModel(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }

  
}
