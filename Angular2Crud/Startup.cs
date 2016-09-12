using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular2Crud.Startup))]
namespace Angular2Crud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
