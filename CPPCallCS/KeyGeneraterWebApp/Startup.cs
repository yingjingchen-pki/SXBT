using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KeyGeneraterWebApp.Startup))]
namespace KeyGeneraterWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
