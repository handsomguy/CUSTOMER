using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerReport.Startup))]
namespace CustomerReport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
