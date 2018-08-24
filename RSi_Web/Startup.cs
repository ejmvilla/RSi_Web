using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RSi_Web.Startup))]
namespace RSi_Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
