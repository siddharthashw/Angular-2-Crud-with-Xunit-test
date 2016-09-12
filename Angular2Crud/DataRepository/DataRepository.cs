using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Angular2Crud.DataRepository
{
    public class DataRepository<T>:IDataRepository<T> where T:class
    {
        private DbContext db;
        private DbSet<T> dbSet;

        public DataRepository(DbContext context)
        {
            this.db = context;
            dbSet = db.Set<T>();
        }

        /// <summary>
        /// To get List of all from database 
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return dbSet.AsQueryable(); ;
        }

        /// <summary>
        /// To search any data by its integer Id number
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T GetById(int? id)
        {
            return dbSet.Find(id);
        }

        /// <summary>
        /// Method to add data in database
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(T entity)
        {
            dbSet.Add(entity);
            db.SaveChanges();
        }

        /// <summary>
        /// Method to delete data from database from its integer Id
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int? id)
        {
            dbSet.Remove(dbSet.Find(id));
            db.SaveChanges();
        }

        /// <summary>
        /// Method to update data in existing database
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        /// <summary>
        /// Method use to save changes in database
        /// </summary>
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        /// <summary>
        /// Dispose Method
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}