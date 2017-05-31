using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSharp_Project.Startup))]
namespace CSharp_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
