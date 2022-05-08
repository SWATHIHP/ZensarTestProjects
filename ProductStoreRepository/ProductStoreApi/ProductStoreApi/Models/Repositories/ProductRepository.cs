using ProductStoreApi.Models.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStoreApi.Models.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DatabaseContext dbContext) : base(dbContext)
        {

        }
    }
}
