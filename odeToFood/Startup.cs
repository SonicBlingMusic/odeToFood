using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(odeToFood.Startup))]
namespace odeToFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
