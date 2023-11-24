using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webbanhang.Startup))]
namespace Webbanhang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
