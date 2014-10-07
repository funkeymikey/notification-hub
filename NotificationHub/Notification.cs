using System;

namespace NotificationHub
{
    public class Notification
    {
        public string Person { get; private set; }
        public string Action { get; private set; }

        public Notification(String person, String action)
        {
            this.Person = person;
            this.Action = action;
        }

        public override string ToString()
        {
            return this.Person + " " + Action;
        }
    }
}