using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CampusBets.Startup))]
namespace CampusBets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
