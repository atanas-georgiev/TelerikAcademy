using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestExam.WebForms.Startup))]
namespace TestExam.WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
