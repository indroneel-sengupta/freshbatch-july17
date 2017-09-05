using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCGlobalizationDemo.Startup))]
namespace MVCGlobalizationDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
