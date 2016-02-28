using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zolla.Web.Startup))]
namespace Zolla.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
