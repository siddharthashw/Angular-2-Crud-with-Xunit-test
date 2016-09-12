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
        /**
        * @api {get} api/blog
        * @apiVersion 1.0.0
        * @apiName GetAll
        * @apiGroup GetAll    
        * @apiSuccessExample {json} Success-Response:
        * HTTP/1.1 200 OK 
        * {
        *     [
                  {
                    "Id": 3,
                    "Name": "Siddhartha Shaw",
                    "Description": "Hello",
                    "Date": "2016-09-12T05:03:25.857"
                  },
                  {
                    "Id": 4,
                    "Name": "Siddhartha",
                    "Description": "Hello All",
                    "Date": "2016-09-12T05:03:28.373"
                  },
              ]
        * }
        */
        [HttpGet]
        [Route("api/blog")]
        public IHttpActionResult GetAll()
        {
            var blogs = _blogRepository.GetAll().ToList();
            return Ok(blogs);
        }

        /**
        * @api {get} api/blog/{id}
        * @apiVersion 1.0.0
        * @apiName GetById
        * @apiGroup GetById    
        * @apiParam {integer} Name  id
        * @apiSuccessExample {json} Success-Response:
        * HTTP/1.1 200 OK 
        * {            
            {
                "Id": 4,
                "Name": "Siddhartha",
                "Description": "Hello All",
                "Date": "2016-09-12T05:03:28.373"
            },
        * }
        */
        [HttpGet]
        [Route("api/blog/{id}")]
        public IHttpActionResult GetById(int id)
        {
            var blog = _blogRepository.GetById(id);
            return Ok(blog);
        }

        /**
        * @api {get} api/blog/add
        * @apiVersion 1.0.0
        * @apiName Add
        * @apiGroup Add    
        * @apiParam {Blog} Name  blog
        * @apiSuccessExample {json} Success-Response:
        * HTTP/1.1 200 OK 
        * {            
            {
                "Id": 4,
               "Name": "Siddhartha",
                "Description": "Hello All",
                "Date": "2016-09-12T05:03:28.373"
            },
        * }
        */
        [HttpPost]
        [Route("api/blog/add")]
        public IHttpActionResult Add(Blog blog)
        {
            _blogRepository.Add(blog);
            return Ok(blog);
        }

        /**
        * @api {get} api/blog/update
        * @apiVersion 1.0.0
        * @apiName Put
        * @apiGroup Put    
        * @apiParam {Blog} Name  blog
        * @apiSuccessExample {json} Success-Response:
        * HTTP/1.1 200 OK 
        * {            
            {
                "Id": 4,
                "Name": "Siddhartha",
                "Description": "Hello",
                "Date": "2016-09-12T05:03:28.373"
            },
        * }
        */
        [HttpPut]
        [Route("api/blog/update")]
        public IHttpActionResult Put(Blog blog)
        {
            _blogRepository.Update(blog);
            return Ok(blog);
        }

        /**
        * @api {delete} api/blog/delete/{id}
        * @apiVersion 1.0.0
        * @apiName Delete
        * @apiGroup Delete    
        * @apiParam {integer} Name  id
        * @apiSuccessExample {json} Success-Response:
        * HTTP/1.1 200 OK 
        * {            
            {
                Description : "This api will delete the blog by its id"
            },
        * }
        */
        [HttpDelete]
        [Route("api/blog/delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            _blogRepository.Delete(id);
            return Ok("");
        }
    }
}