using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoNot.Startup))]
namespace SoNot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
