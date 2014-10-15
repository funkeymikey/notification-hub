using Microsoft.AspNet.SignalR;
using System.Web.Http;

namespace NotificationHub
{
    public class NotificationsController : ApiController
    {
        // when a notification is posted to this endpoint, fire it off to any that might be listening on the hub
        public void Post([FromBody] NotificationMessage notification)
        {
            if (notification == null)
                return;

            IHubContext notificationHub = GlobalHost.ConnectionManager.GetHubContext<NotificationsHub>();
            notificationHub.Clients.All.notify(notification);
        }

    }
}