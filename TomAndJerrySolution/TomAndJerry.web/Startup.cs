using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TomAndJerry.web.Startup))]
namespace TomAndJerry.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
