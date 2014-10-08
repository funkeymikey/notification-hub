using Microsoft.AspNet.SignalR;

namespace NotificationHub
{
    // this is empty because we only invoke the Clients.All.notify(Notification) from within the api controller
    public class NotificationsHub : Hub
    {
        public void Heartbeat()
        {
        }
    }
}