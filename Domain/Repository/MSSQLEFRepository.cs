using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Domain.Repository
{
    class MSSQLEFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        DbContext context;
        DbSet<TEntity> dbSet;

        public MSSQLEFRepository(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public void Create(TEntity item)
        {
            dbSet.Add(item);
            context.SaveChanges();
        }

        public IQueryable<TEntity> Read()
        {
            return dbSet;
        }

        public void Update(TEntity item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(TEntity item)
        {
            dbSet.Remove(item);
            context.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
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
