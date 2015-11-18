using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HolidayPlaces.Startup))]
namespace HolidayPlaces
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
