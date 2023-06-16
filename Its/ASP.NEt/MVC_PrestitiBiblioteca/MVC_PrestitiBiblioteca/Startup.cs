using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_PrestitiBiblioteca.Startup))]
namespace MVC_PrestitiBiblioteca
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
