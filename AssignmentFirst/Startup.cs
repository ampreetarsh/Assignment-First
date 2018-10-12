using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssignmentFirst.Startup))]
namespace AssignmentFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
