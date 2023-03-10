using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HuynhDucPhat_1811062779_BigSchool.Startup))]
namespace HuynhDucPhat_1811062779_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
