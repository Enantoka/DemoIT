using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoIT.Startup))]
namespace DemoIT
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
