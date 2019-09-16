using System.Collections.Generic;
using dtos;

namespace entities
{
    public class FCMMessage
    {
        public virtual Dictionary<string,string> notification { get; set; }
        public virtual Dictionary<string, string> data { get; set; }
        public virtual string condition { get; set; }

        public FCMMessage(NotificationDTO notificationToSend)
        {
            notification = new Dictionary<string, string>();
            data = new Dictionary<string, string>();
            notification.Add("title", notificationToSend.NotificationTitle);
            notification.Add("body",notificationToSend.NotificationSubtitle);
            if (notificationToSend.CountryList != null)
            {
                foreach (string country in notificationToSend.CountryList)
                {
                    condition = condition + "'" + country + "'" + " in topics || ";
                }
            }

            if (notificationToSend.PreferenceList != null)
            {
                foreach (PreferenceDTO preference in notificationToSend.PreferenceList)
                {
                    condition = condition + "'" + preference.Name + "'" + " in topics || ";
                }
            }

            data.Add("landing_page", "promocion");
            data.Add("message",notificationToSend.NotificationBody);

            condition = condition.Remove(condition.Length - 4);
        }
    }
}