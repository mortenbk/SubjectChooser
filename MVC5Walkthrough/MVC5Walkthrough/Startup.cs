using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Walkthrough.Startup))]
namespace MVC5Walkthrough
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
