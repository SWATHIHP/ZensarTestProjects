using ProductStoreMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductStoreMvc.DAL
{
    public class AllRepository<T> : _IAllRepository<T> where T : class
    {
        private ProductStoreEntities _context;
        private IDbSet<T> dbEntity;

        public AllRepository()
        {
            _context = new ProductStoreEntities();
            dbEntity = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbEntity.ToList();
        }

        public T GetById(int modelId)
        {
            return dbEntity.Find(modelId);
        }

        public void Insert(T model)
        {
            dbEntity.Add(model);
        }
        
        public  void Update(T model)
        {
            _context.Entry(model).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int modelID)
        {
            T model = dbEntity.Find(modelID);
            dbEntity.Remove(model);
        }

        public  void Save()
        {
            _context.SaveChanges();
        }
    }
}