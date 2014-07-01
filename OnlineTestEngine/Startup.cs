using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineTestEngine.Startup))]
namespace OnlineTestEngine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
