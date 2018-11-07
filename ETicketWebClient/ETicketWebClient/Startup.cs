using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ETicketWebClient.Startup))]
namespace ETicketWebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
