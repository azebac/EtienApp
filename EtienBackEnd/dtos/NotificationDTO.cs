using System.Collections.Generic;

namespace dtos
{
    public class NotificationDTO
    {
        public IList<string> CountryList { get; set; }
        public IList<PreferenceDTO> PreferenceList { get; set; }
        public string NotificationBody { get; set; }
        public string NotificationTitle { get; set; }

        public string NotificationSubtitle { get; set; }

        public NotificationDTO(IList<string> countryList, IList<PreferenceDTO> preferenceList,
            string notificationBody, string notificationTitle, string notificationSubtitle)
        {
            CountryList = countryList;
            PreferenceList = preferenceList;
            NotificationBody = notificationBody;
            NotificationTitle = notificationTitle;
            NotificationSubtitle = notificationSubtitle;
        }
    }
}