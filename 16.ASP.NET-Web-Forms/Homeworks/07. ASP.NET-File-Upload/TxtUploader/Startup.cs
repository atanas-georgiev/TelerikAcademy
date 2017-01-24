using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TxtUploader.Startup))]
namespace TxtUploader
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
