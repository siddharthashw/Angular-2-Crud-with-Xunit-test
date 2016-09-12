using System;
using System.Collections.Generic;
using Angular2Crud.Models;
using Angular2Crud.DataRepository;

namespace Angular2Crud.BlogRepository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly IDataRepository<Blog> _blogDataRepository;
        public BlogRepository(IDataRepository<Blog> blogDataRepository)
        {
            _blogDataRepository = blogDataRepository;
        }
        public void Add(Blog blog)
        {
            blog.Date = DateTime.UtcNow;
            _blogDataRepository.Insert(blog);
            _blogDataRepository.Save();
        }

        public void Delete(int id)
        {
            _blogDataRepository.Delete(id);
            _blogDataRepository.Save();
        }

        public IEnumerable<Blog> GetAll()
        {
            var blogs = _blogDataRepository.GetAll();
            return blogs;
        }

        public Blog GetById(int id)
        {
            var blog = _blogDataRepository.GetById(id);
            return blog;
        }

        public void Update(Blog blog)
        {
            _blogDataRepository.Update(blog);
            _blogDataRepository.Save();
        }
    }
}