using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameBot.Startup))]
namespace GameBot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
