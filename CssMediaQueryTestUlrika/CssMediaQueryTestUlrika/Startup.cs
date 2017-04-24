using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CssMediaQueryTestUlrika.Startup))]
namespace CssMediaQueryTestUlrika
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
