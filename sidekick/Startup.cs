using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sidekick.Startup))]
namespace sidekick
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
