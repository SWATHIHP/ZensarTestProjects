using ProductStoreApi.Models.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStoreApi.Models.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        //public List<Product> Search(string keyword);
    }
}
