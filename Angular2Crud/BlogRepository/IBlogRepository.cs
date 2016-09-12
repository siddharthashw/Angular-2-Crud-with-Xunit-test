using Angular2Crud.Models;
using System.Collections.Generic;

namespace Angular2Crud.BlogRepository
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> GetAll();
        Blog GetById(int id);
        void Add(Blog blog);
        void Delete(int id);
        void Update(Blog blog);
    }
}
