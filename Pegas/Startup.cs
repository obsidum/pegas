using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pegas.Startup))]
namespace Pegas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
