using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OldSchool.Startup))]
namespace OldSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
