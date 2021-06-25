using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(THWebB3.Startup))]
namespace THWebB3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
