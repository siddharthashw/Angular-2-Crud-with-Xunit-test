using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular2Crud.DataRepository
{
    public interface IDataRepository<T> : IDisposable
    {
        IQueryable<T> GetAll();
        T GetById(int? id);
        void Insert(T entity);
        void Delete(int? id);
        void Update(T entity);
        void Save();
    }
}
