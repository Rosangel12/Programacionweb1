using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CLUBPROGFINALA.Startup))]
namespace CLUBPROGFINALA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
