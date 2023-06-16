using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Database3.Startup))]
namespace MVC_Database3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
