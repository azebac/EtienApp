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
            notification.Add("body",notificationToSend.NotificationBody);
            if (notificationToSend.CountryList != null)
            {
                foreach (CountryDTO country in notificationToSend.CountryList)
                {
                    condition = condition + "'" + country.Name + "'" + " in topics || ";
                }
            }

            if (notificationToSend.PreferenceList != null)
            {
                foreach (PreferenceDTO preference in notificationToSend.PreferenceList)
                {
                    condition = condition + "'" + preference.Name + "'" + " in topics || ";
                }
            }

            condition = condition.Remove(condition.Length - 4);
        }
    }
}