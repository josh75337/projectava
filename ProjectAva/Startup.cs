using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectAva.Startup))]
namespace ProjectAva
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
