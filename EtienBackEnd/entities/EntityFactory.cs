using System.Collections.Generic;
using enums;

namespace entities
{
    public static class EntityFactory
    {
        public static PreferenceEntity CreatePreferenceEntity(long id = 0, string name = null,
            IList<UserEntity> associatedUsers = null)
        {
            return new PreferenceEntity(id, name, associatedUsers);
        }

        public static UserEntity CreateUserEntity(long id = 0, string name = null, string lastName = null,
            string userName = null, string password = null, string email = null, string cellphone = null,
            UserGenderType gender = UserGenderType.Female, UserStatusType status = UserStatusType.Active,
            CountryEntity country = null, IList<PreferenceEntity> selectedPreferences = null)
        {
            
            return new UserEntity(id, name, lastName, userName, password,email, cellphone, gender, status,
                country, selectedPreferences);
        }

        public static CountryEntity CreateCountryEntity(long id = 0, string name = null,
            IList<UserEntity> associatedUsers = null)
        {
            return new CountryEntity(id, name, associatedUsers);
        }
    }
}