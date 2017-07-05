using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportsNews.App.Startup))]
namespace SportsNews.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
