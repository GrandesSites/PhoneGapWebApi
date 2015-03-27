using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi.Domain.Models;
using WebApiRepository.Interfaces;

namespace WebApiRepository
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected DB_9BB59F_siteContext Db = new DB_9BB59F_siteContext();

        public void Add(TEntity obj)
        {
            Db.Database.Log = (s) => System.Diagnostics.Debug.Write(s);
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }
        public TEntity GetById(int id)
        {
            Db.Database.Log = (s) => System.Diagnostics.Debug.Write(s);
            return Db.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            Db.Database.Log = (s) => System.Diagnostics.Debug.Write(s);
            return Db.Set<TEntity>().ToList();
        }
        public void Update(TEntity obj)
        {
            Db.Database.Log = (s) => System.Diagnostics.Debug.Write(s);
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
        public void Remove(TEntity obj)
        {
            Db.Database.Log = (s) => System.Diagnostics.Debug.Write(s);
            Db.Entry(obj).State = EntityState.Deleted;
            Db.SaveChanges();

        }
        public void Dispose()
        {
            Db.Dispose();
        }
    }
}