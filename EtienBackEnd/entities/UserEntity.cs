using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        public virtual UserGenderType Gender { get; set; }
        public virtual UserStatusType Status { get; set; }
        public virtual CountryEntity Country { get; set; }
        public virtual IList<PreferenceEntity> SelectedPreferences { get; set; }


        public UserEntity(long id, string name, string lastName, string userName, string password, string email,
            string cellphone, bool isReseller, UserGenderType gender, UserStatusType status, CountryEntity country,
            IList<PreferenceEntity> selectedPreferences) : base(id)
        {
            Name = name;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Email = email;
            Cellphone = cellphone;
            IsReseller = isReseller;
            Gender = gender;
            Status = status;
            Country = country;
            SelectedPreferences = selectedPreferences;
        }
    }
}