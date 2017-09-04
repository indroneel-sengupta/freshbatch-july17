using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCValidationDemo.Startup))]
namespace MVCValidationDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
