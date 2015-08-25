using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angie.Startup))]
namespace Angie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
