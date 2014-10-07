using Microsoft.AspNet.SignalR;
using System.Web.Http;

namespace NotificationHub
{
    public class NotificationsController : ApiController
    {
        // when a notification is sent to this endpoint, fire it off to any that might be listening on the hub
        public void Post([FromBody] Notification notification)
        {
            if (notification == null)
                return;

            IHubContext notificationHubContext = GlobalHost.ConnectionManager.GetHubContext<NotificationsHub>();
            notificationHubContext.Clients.All.notify(notification);
        }

    }
}