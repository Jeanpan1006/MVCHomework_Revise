using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCHomeWork_Update.Startup))]
namespace MVCHomeWork_Update
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
