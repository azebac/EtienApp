using System.Collections.Generic;

namespace dtos
{
    public class NotificationDTO
    {
        public IList<CountryDTO> CountryList { get; set; }
        public IList<PreferenceDTO> PreferenceList { get; set; }
        public string NotificationBody { get; set; }
        public string NotificationTitle { get; set; }

        public NotificationDTO(IList<CountryDTO> countryList, IList<PreferenceDTO> preferenceList,
            string notificationBody, string notificationTitle)
        {
            CountryList = countryList;
            PreferenceList = preferenceList;
            NotificationBody = notificationBody;
            NotificationTitle = notificationTitle;
        }
    }
}