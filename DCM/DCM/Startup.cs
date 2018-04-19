using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DCM.Startup))]
namespace DCM
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
