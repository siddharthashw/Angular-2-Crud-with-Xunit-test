using Angular2Crud.Models;
using System.Collections.Generic;

namespace Angular2Crud.BlogRepository
{
    public interface IBlogRepository
    {
        /// <summary>
        /// Method to get all blogs
        /// </summary>
        /// <returns>list of blogs</returns>
        IEnumerable<Blog> GetAll();

        /// <summary>
        /// Method to get blog by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Blog GetById(int id);

        /// <summary>
        /// Method to add blog
        /// </summary>
        /// <param name="blog"></param>
        void Add(Blog blog);

        /// <summary>
        /// Method to delete blog
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// Method to update blog
        /// </summary>
        /// <param name="blog"></param>
        void Update(Blog blog);
    }
}
