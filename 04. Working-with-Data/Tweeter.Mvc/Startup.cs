using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tweeter.Mvc.Startup))]
namespace Tweeter.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
