using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ENNEM.Startup))]
namespace ENNEM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
