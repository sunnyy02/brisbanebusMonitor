using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrisbaneBusMonitor.Startup))]
namespace BrisbaneBusMonitor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
