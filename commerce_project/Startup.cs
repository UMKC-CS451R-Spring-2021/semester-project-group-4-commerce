using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(commerce_project.Startup))]
namespace commerce_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
