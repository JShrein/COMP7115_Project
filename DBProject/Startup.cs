using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBProject.Startup))]
namespace DBProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
