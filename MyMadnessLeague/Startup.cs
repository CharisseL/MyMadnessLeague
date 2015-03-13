using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMadnessLeague.Startup))]
namespace MyMadnessLeague
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
