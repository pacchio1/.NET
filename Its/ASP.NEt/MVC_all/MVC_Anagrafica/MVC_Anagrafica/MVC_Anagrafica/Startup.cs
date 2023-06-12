using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Anagrafica.Startup))]
namespace MVC_Anagrafica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
