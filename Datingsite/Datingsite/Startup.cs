using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Datingsite.Startup))]
namespace Datingsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
