using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDataBase.Startup))]
namespace MVCDataBase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
