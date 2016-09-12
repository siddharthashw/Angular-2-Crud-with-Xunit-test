using Angular2Crud.BlogRepository;
using Angular2Crud.Models;
using Angular2Crud.StringConstant;
using Autofac;
using System.Linq;
using Xunit;

namespace Angular2CrudTest
{
    public class BlogRepositoryTest
    {
        private readonly IComponentContext _componentContext;
        private readonly IBlogRepository _blogRepository;
        public BlogRepositoryTest()
        {
            _componentContext = AutofacConfig.RegisterDependancies();
            _blogRepository = _componentContext.Resolve<IBlogRepository>();
        }

        /// <summary>
        /// Test case to check add method of blog repository
        /// </summary>
        [Fact]
        public void Add()
        {
            _blogRepository.Add(blog);
            Assert.Equal(blog.Id, 1);
        }

        /// <summary>
        /// Test case to check add method of blog repository
        /// </summary>
        [Fact]
        public void GetAll()
        {
            _blogRepository.Add(blog);
            _blogRepository.Add(blog);
            _blogRepository.Add(blog);
            var blogs = _blogRepository.GetAll();
            Assert.Equal(blogs.Count(), 3);
        }

        /// <summary>
        /// Test case to check add method of blog repository
        /// </summary>
        [Fact]
        public void GetById()
        {
            _blogRepository.Add(blog);
            var newBlog = _blogRepository.GetById(blog.Id);
            Assert.Equal(blog, newBlog);
        }

        /// <summary>
        /// Test case to check add method of blog repository
        /// </summary>
        [Fact]
        public void Update()
        {
            _blogRepository.Add(blog);
            blog.Name = StringConstant.NewName;
            _blogRepository.Update(blog);
            Assert.Equal(blog.Name, StringConstant.NewName);
        }

        /// <summary>
        /// Test case to check add method of blog repository
        /// </summary>
        [Fact]
        public void Delete()
        {
            _blogRepository.Add(blog);
            _blogRepository.Add(blog);
            _blogRepository.Add(blog);
            _blogRepository.Delete(2);
            var blogs = _blogRepository.GetAll();
            Assert.Equal(blogs.Count(), 2);
        }

        private Blog blog = new Blog()
        {
            Name = StringConstant.Name,
            Description = StringConstant.Description
        };
    }
}
