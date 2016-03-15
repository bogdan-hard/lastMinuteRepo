using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitProject.Startup))]
namespace gitProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
