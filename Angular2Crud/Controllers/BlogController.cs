using Angular2Crud.BlogRepository;
using Angular2Crud.Models;
using System.Linq;
using System.Web.Http;

namespace Angular2Crud.Controllers
{
    public class BlogController : ApiController
    {
        private readonly IBlogRepository _blogRepository;
        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        [HttpGet]
        [Route("api/blog")]
        public IHttpActionResult GetAll()
        {
            var blogs = _blogRepository.GetAll().ToList();
            return Ok(blogs);
        }

        [HttpGet]
        [Route("api/blog/{id}")]
        public IHttpActionResult GetById(int id)
        {
            var blog = _blogRepository.GetById(id);
            return Ok(blog);
        }

        [HttpPost]
        [Route("api/blog/add")]
        public IHttpActionResult Add([FromBody]Blog blog)
        {
            _blogRepository.Add(blog);
            return Ok(blog);
        }

        [HttpPut]
        [Route("api/blog/update")]
        public IHttpActionResult Put(Blog blog)
        {
            _blogRepository.Update(blog);
            return Ok(blog);
        }

        [HttpDelete]
        [Route("api/blog/delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            _blogRepository.Delete(id);
            return Ok("");
        }
    }
}