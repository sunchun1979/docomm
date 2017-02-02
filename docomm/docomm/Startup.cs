using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(docomm.Startup))]
namespace docomm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
