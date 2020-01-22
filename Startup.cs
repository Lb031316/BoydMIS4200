using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BoydMIS4200.Startup))]
namespace BoydMIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
