using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FIT_5032MyDatabaseFirst.Startup))]
namespace FIT_5032MyDatabaseFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
