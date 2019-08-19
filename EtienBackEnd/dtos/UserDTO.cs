using System.Collections.Generic;
using enums;

namespace dtos
{
    public class UserDTO:BaseDTO
    {
        public virtual string Name { get; set; }
        public virtual string LastName { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string Email { get; set; }
        public virtual string Cellphone { get; set; }
        public virtual UserGenderType Gender { get; set; }
        public virtual UserStatusType Status { get; set; }
        public virtual CountryDTO Country { get; set; }
        public virtual IList<PreferenceDTO> SelectedPreferences { get; set; }

        public UserDTO(long id, string name, string lastName, string userName, string password, string email,
            string cellphone, UserGenderType gender, UserStatusType status, CountryDTO country,
            IList<PreferenceDTO> selectedPreferences) : base(id)
        {
            Name = name;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Email = email;
            Cellphone = cellphone;
            Gender = gender;
            Status = status;
            Country = country;
            SelectedPreferences = selectedPreferences;
        }
    }
}