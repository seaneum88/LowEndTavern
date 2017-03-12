using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LowEndTevern.Startup))]
namespace LowEndTevern
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
