using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryMVC1.Startup))]
namespace TryMVC1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
