using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Task03_TweetsAggregator.Startup))]
namespace Task03_TweetsAggregator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
