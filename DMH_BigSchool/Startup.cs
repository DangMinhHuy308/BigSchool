using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DMH_BigSchool.Startup))]
namespace DMH_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
