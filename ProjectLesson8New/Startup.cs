using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectLesson8New.Startup))]
namespace ProjectLesson8New
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
