using Microsoft.Owin;
using Owin;
using YoutubePlaylists.WebForms;

[assembly: OwinStartup(typeof(Startup))]
namespace YoutubePlaylists.WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
