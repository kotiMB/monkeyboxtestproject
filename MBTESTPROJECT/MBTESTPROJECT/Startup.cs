using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MBTESTPROJECT.Startup))]
namespace MBTESTPROJECT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
