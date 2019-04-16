using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cars.Startup))]
namespace cars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
