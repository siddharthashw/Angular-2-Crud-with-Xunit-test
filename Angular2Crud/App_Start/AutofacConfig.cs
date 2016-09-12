using Angular2Crud.BlogRepository;
using Angular2Crud.Controllers;
using Angular2Crud.DataRepository;
using Angular2Crud.Models;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;

namespace Angular2Crud.App_Start
{
    public class AutofacConfig
    {
        public static IComponentContext RegisterDependancies()
        {
            var builder = new ContainerBuilder();
            // register dependency
            builder.RegisterType<ApplicationDbContext>().As<DbContext>();
            builder.RegisterControllers(typeof(HomeController).Assembly);
            builder.RegisterApiControllers(typeof(BlogController).Assembly);
            builder.RegisterGeneric(typeof(DataRepository<>)).As(typeof(IDataRepository<>));
            builder.RegisterType<BlogRepository.BlogRepository>().As<IBlogRepository>();
            var container = builder.Build();
            // replace mvc dependancy resolver with autofac
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            // replace webapi dependancy resolver with autofac
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            return container;
        }
    }
}