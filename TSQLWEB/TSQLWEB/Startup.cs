using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TSQLWEB.Startup))]
namespace TSQLWEB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
