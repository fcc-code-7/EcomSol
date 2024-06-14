using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EcomSol.Webs.Startup))]
namespace EcomSol.Webs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
