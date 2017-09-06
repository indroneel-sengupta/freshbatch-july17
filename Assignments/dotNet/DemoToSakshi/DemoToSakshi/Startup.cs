using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoToSakshi.Startup))]
namespace DemoToSakshi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
