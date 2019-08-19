using System.Collections.Generic;
using enums;

namespace dtos
{
    public static class DTOFactory
    {
        public static CountryDTO CreateCountryDTO(long id = 0, string name = null)
        {
            return new CountryDTO(id, name);
        }

        public static PreferenceDTO CreatePreferenceDto(long id = 0, string name = null)
        {
            return new PreferenceDTO(id, name);
        }

        public static UserDTO CreateUserDto(long id = 0, string name = null, string lastName = null,
            string userName = null, string password = null, string email = null,
            string cellphone = null, UserGenderType gender = UserGenderType.Female,
            UserStatusType status = UserStatusType.Active, CountryDTO country = null,
            IList<PreferenceDTO> selectedPreferences = null)
        {
            return new UserDTO(id, name, lastName, userName, password, email,
                cellphone, gender, status, country, selectedPreferences);
        }
    }
}