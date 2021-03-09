using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kutse_app.Startup))]
namespace Kutse_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
