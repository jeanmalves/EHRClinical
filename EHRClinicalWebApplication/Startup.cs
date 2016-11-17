using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EHRClinicalWebApplication.Startup))]
namespace EHRClinicalWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
