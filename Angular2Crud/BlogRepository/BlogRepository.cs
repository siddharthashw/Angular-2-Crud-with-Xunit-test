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

        /// <summary>
        /// Method to add blog
        /// </summary>
        /// <param name="blog"></param>
        public void Add(Blog blog)
        {
            blog.Date = DateTime.UtcNow;
            _blogDataRepository.Insert(blog);
            _blogDataRepository.Save();
        }

        /// <summary>
        /// Method to delete blog
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            _blogDataRepository.Delete(id);
            _blogDataRepository.Save();
        }

        /// <summary>
        /// Method to get all blogs
        /// </summary>
        /// <returns>list of blogs</returns>
        public IEnumerable<Blog> GetAll()
        {
            var blogs = _blogDataRepository.GetAll();
            return blogs;
        }

        /// <summary>
        /// Method to get blog by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Blog GetById(int id)
        {
            var blog = _blogDataRepository.GetById(id);
            return blog;
        }

        /// <summary>
        /// Method to update blog
        /// </summary>
        /// <param name="blog"></param>
        public void Update(Blog blog)
        {
            _blogDataRepository.Update(blog);
            _blogDataRepository.Save();
        }
    }
}