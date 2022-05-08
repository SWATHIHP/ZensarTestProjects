using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStoreApi.Models.EfCore
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> FindAll();
        Task<TEntity> FindById(int id);
        Task InsertModel(TEntity entity);
        Task UpdateModel(int id, TEntity entity);
        Task DeleteModel (int id);
    }
}
