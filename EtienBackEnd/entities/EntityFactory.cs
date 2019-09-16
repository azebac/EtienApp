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

        public static UserEntity CreateUserEntityForUpdate(UserDTO dto, UserEntity user)
        {
            user.Name = dto.Name;
            user.LastName = dto.LastName;
            user.UserName = dto.UserName;
            user.Password = dto.Password;
            user.Email = dto.Email;
            user.UserDeviceId = dto.UserDeviceId;
            user.Cellphone = dto.Cellphone;
            user.AppToken = dto.AppToken;
            user.Status = dto.Status;
            user.Gender = dto.Gender;
            user.Country = CreateCountryEntity(dto.Country);
            user.SelectedPreferences = new List<PreferenceEntity>();
            foreach (PreferenceDTO preference in dto.SelectedPreferences)
            {
                user.SelectedPreferences.Add(CreatePreferenceEntity(preference));
            }

            return user;
        }



        public static CountryEntity CreateCountryEntity(long id = 0, string name = null, string iso = null,
            string niceName = null, string iso3 = null, int numCode = 0, int phoneCode = 0,
            IList<UserEntity> associatedUsers = null)
        {
            return new CountryEntity(id, name, iso, niceName, iso3, numCode, phoneCode,
                associatedUsers);
        }

        public static CountryEntity CreateCountryEntity(CountryDTO country)
        {
            return new CountryEntity(country);
        }

        public static PreferenceEntity CreatePreferenceEntity(PreferenceDTO preference)
        {
            return new PreferenceEntity(preference);
        }
    }
}