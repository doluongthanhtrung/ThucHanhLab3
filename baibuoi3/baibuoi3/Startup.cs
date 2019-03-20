using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(baibuoi3.Startup))]
namespace baibuoi3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
