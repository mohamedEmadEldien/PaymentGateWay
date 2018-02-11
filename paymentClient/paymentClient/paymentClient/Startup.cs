using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(paymentClient.Startup))]
namespace paymentClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
