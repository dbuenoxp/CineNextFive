using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Solution.NextFive.CineWeb.Startup))]
namespace Solution.NextFive.CineWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
