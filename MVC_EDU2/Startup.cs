using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_EDU2.Startup))]
namespace MVC_EDU2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
