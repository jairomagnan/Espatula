using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Espatula.Startup))]
namespace Espatula
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
