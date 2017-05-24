using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5_Stars_Reviews.Startup))]
namespace _5_Stars_Reviews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
