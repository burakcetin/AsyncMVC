using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AsyncMVC.Startup))]
namespace AsyncMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
