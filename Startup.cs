using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SprintOApp.Startup))]
namespace SprintOApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
