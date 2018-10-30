using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CostCracker.Startup))]
namespace CostCracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
