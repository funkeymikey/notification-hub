using System;

namespace NotificationHub
{
    public class NotificationMessage
    {
        /// <summary> The person that did something </summary>
        public string Person { get; private set; }

        /// <summary> The event that happened </summary>
        public string Action { get; private set; }

        public NotificationMessage(String person, String action, DateTime at)
        {
            this.Person = person;
            this.Action = action;
        }

        public override string ToString()
        {
            return this.Person + " " + this.Action;
        }
    }
}