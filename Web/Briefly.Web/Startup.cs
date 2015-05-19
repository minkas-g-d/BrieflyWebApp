using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Briefly.Web.Startup))]
namespace Briefly.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
