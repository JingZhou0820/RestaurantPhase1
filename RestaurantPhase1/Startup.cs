using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantPhase1.Startup))]
namespace RestaurantPhase1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
