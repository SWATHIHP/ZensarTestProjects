using ProductStoreApi.Models.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStoreApi.Models.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DatabaseContext dbContext) : base(dbContext)
        {

        }
    }
}
