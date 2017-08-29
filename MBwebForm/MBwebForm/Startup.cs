using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MBwebForm.Startup))]
namespace MBwebForm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
