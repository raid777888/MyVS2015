using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSpider.Startup))]
namespace WebSpider
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
