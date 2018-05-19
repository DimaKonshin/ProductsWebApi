using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IRepository<TEntity>:IDisposable where TEntity:class
    {
        void Create(TEntity item);
        IQueryable<TEntity> Read();
        void Update(TEntity item);
        void Delete(TEntity item);
    }
}
