using Microsoft.AspNet.SignalR;

namespace NotificationHub
{
    // we invoke the Clients.All.notify(Notification) directly from the api controller
    public class NotificationsHub : Hub
    {
        /// <summary> Called by the client to ensure connectivity </summary>
        public void Heartbeat() { }
    }
}