using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(D_Blood.Startup))]
namespace D_Blood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
