using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScaffoldingTest.Startup))]
namespace ScaffoldingTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
