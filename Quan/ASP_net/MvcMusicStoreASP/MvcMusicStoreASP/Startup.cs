using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMusicStoreASP.Startup))]
namespace MvcMusicStoreASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
