using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoToNinad.Startup))]
namespace DemoToNinad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
