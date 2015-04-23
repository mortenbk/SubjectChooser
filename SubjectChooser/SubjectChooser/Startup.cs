using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SubjectChooser.Startup))]
namespace SubjectChooser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
