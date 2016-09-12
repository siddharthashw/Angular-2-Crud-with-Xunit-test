using Angular2Crud.BlogRepository;
using Angular2Crud.DataRepository;
using Angular2Crud.Models;
using Autofac;
using Effort;
using System.Data.Entity;

namespace Angular2CrudTest
{
    public class AutofacConfig
    {
        public static IComponentContext RegisterDependancies()
        {
            var builder = new ContainerBuilder();
            // register dependency
            var dataContext = new ApplicationDbContext(DbConnectionFactory.CreateTransient());
            builder.RegisterInstance(dataContext).As<DbContext>().SingleInstance();
            builder.RegisterGeneric(typeof(DataRepository<>)).As(typeof(IDataRepository<>));
            builder.RegisterType<BlogRepository>().As<IBlogRepository>();
            var container = builder.Build();
            return container;
        }
    }
}
