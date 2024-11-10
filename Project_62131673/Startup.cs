using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_62131673.Startup))]
namespace Project_62131673
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
