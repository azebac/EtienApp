using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using dtos;
using enums;

namespace entities
{
    public class UserEntity:Entity
    {
        public virtual string Name { get; set; }
        public virtual string LastName { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string Email { get; set; }
        public virtual string Cellphone { get; set; }
        public virtual bool IsReseller { get; set; }
        public virtual bool IsAdmin { get; set; }
        public virtual string Salt { get; set; }
        public virtual string AppToken { get; set; }
        public virtual UserGenderType Gender { get; set; }
        public virtual UserStatusType Status { get; set; }
        public virtual CountryEntity Country { get; set; }
        public virtual IList<PreferenceEntity> SelectedPreferences { get; set; } = new List<PreferenceEntity>();

        public UserEntity()
        {
        }

        public UserEntity(long id, string name, string lastName, string userName, string password, string email,
            string cellphone, bool isReseller, bool isAdmin, string salt, UserGenderType gender, UserStatusType status, CountryEntity country,
            IList<PreferenceEntity> selectedPreferences, string appToken) : base(id)
        {
            Name = name;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Email = email;
            Cellphone = cellphone;
            IsReseller = isReseller;
            IsAdmin = isAdmin;
            Salt = salt;
            Gender = gender;
            Status = status;
            Country = country;
            SelectedPreferences = selectedPreferences;
            AppToken = appToken;
        }

        public UserEntity(UserDTO dto):base(dto.Id)
        {
            Name = dto.Name;
            LastName = dto.LastName;
            UserName = dto.UserName;
            Password = dto.Password;
            Email = dto.Email;
            Cellphone = dto.Cellphone;
            Gender = dto.Gender;
            Status = dto.Status;
            if(dto.Country != null)
                Country = new CountryEntity(dto.Country);
            AppToken = dto.AppToken;
            if (dto.SelectedPreferences != null)
            {
                foreach (PreferenceDTO preference in dto.SelectedPreferences)
                {
                    SelectedPreferences.Add(new PreferenceEntity(preference));
                }
            }

        }

        public virtual UserDTO ConvertToDTO()
        {
            IList<PreferenceDTO> preferences = new List<PreferenceDTO>();
            if (SelectedPreferences != null)
            {
                foreach (PreferenceEntity preference in SelectedPreferences)
                {
                    preferences.Add(preference.ConvertToDTO());
                }
            }

            CountryDTO country = null;
            Country?.ConvertToDTO();
            UserDTO userDto = DTOFactory.CreateUserDto(Id, Name, LastName, UserName, "", Email, Cellphone, Gender,
                Status, country, preferences, AppToken);
            return userDto;
        }
    }
}