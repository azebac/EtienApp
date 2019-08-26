using System.Collections.Generic;
using dtos;
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
            bool isReseller = false, bool isAdmin = false, string salt = null,
            UserGenderType gender = UserGenderType.Female, UserStatusType status = UserStatusType.Active,
            CountryEntity country = null, IList<PreferenceEntity> selectedPreferences = null, string appToken = null,
            string userDeviceEntity = null)
        {
            return new UserEntity(id, name, lastName, userName, password, email, cellphone, isReseller, isAdmin, salt,
                gender,
                status, country, selectedPreferences, appToken, userDeviceEntity);
        }

        public static UserEntity CreateUserEntity(UserDTO dto)
        {
            return new UserEntity(dto);
        }



        public static CountryEntity CreateCountryEntity(long id = 0, string name = null, string iso = null,
            string niceName = null, string iso3 = null, int numCode = 0, int phoneCode = 0,
            IList<UserEntity> associatedUsers = null)
        {
            return new CountryEntity(id, name, iso, niceName, iso3, numCode, phoneCode,
                associatedUsers);
        }
    }
}