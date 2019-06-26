using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phanquyen.Startup))]
namespace Phanquyen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
