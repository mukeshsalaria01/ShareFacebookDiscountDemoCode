using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacebookShareDiscountDemo.Startup))]
namespace FacebookShareDiscountDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
