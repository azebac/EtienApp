using System.Collections.Generic;
using enums;

namespace dtos
{
    public static class DTOFactory
    {
        public static CountryDTO CreateCountryDTO(long id = 0, string name = null, string iso = null,
            string niceName = null, string iso3 = null, int numCode = 0,
            int phoneCode = 0)
        {
            return new CountryDTO(id, name, iso, niceName, iso3, numCode, phoneCode);
        }

        public static PreferenceDTO CreatePreferenceDto(long id = 0, string name = null)
        {
            return new PreferenceDTO(id, name);
        }

        public static UserDTO CreateUserDto(long id = 0, string name = null, string lastName = null,
            string userName = null, string password = null, string email = null,
            string cellphone = null, UserGenderType gender = UserGenderType.Female,
            UserStatusType status = UserStatusType.Active, CountryDTO country = null,
            IList<PreferenceDTO> selectedPreferences = null, string appToken = null, string userDeviceId = null)
        {
            return new UserDTO(id, name, lastName, userName, password, email,
                cellphone, gender, status, country, selectedPreferences, appToken, userDeviceId);
        }

        public static NotificationDTO CreateNotificationDto(IList<CountryDTO> countryList = null, IList<PreferenceDTO> preferenceList = null,
            string notificationBody = null, string notificationTitle = null)
        {
            return new NotificationDTO(countryList, preferenceList, notificationBody,  notificationTitle);
        }
        
    }
}