using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kynapsis.Startup))]
namespace Kynapsis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
