using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStoreMvc.DAL
{
    public interface _IAllRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int modelId);
        void Insert(T model);
        void Update(T model);
        void Delete(int modelID);
        void Save();
    }
}
