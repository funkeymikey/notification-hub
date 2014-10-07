using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(NotificationHub.Startup))]

namespace NotificationHub
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}