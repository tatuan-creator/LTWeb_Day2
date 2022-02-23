using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab2_TranAnhTuan.Startup))]
namespace Lab2_TranAnhTuan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
