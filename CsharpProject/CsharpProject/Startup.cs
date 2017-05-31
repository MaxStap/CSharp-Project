using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CsharpProject.Startup))]
namespace CsharpProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
