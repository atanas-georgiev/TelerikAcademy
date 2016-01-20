using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Task02_WebFormsApp.Startup))]
namespace Task02_WebFormsApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
