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
        public virtual UserGenderType Gender { get; set; }
        public virtual UserStatusType Status { get; set; }
        public virtual CountryEntity Country { get; set; }
        public virtual IList<PreferenceEntity> SelectedPreferences { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Name)}: {Name}, {nameof(LastName)}: {LastName}, {nameof(UserName)}: {UserName}, {nameof(Password)}: {Password}, {nameof(Email)}: {Email}, {nameof(Cellphone)}: {Cellphone}, {nameof(Gender)}: {Gender}, {nameof(Status)}: {Status}, {nameof(Country)}: {Country.Name}, {nameof(SelectedPreferences)}: {SelectedPreferences}";
        }

        public UserEntity()
        {
        }

        public UserEntity(long id, string name, string lastName, string userName, string password, string email, string cellphone, UserGenderType gender, UserStatusType status, CountryEntity country, IList<PreferenceEntity> selectedPreferences) : base(id)
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

        protected bool Equals(UserEntity other)
        {
            return string.Equals(Name, other.Name) && string.Equals(LastName, other.LastName) && string.Equals(UserName, other.UserName) && string.Equals(Password, other.Password) && string.Equals(Email, other.Email) && string.Equals(Cellphone, other.Cellphone) && Gender == other.Gender && Status == other.Status && Equals(Country, other.Country) && Equals(SelectedPreferences, other.SelectedPreferences);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((UserEntity) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = base.GetHashCode();
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (LastName != null ? LastName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (UserName != null ? UserName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Password != null ? Password.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Email != null ? Email.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Cellphone != null ? Cellphone.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int) Gender;
                hashCode = (hashCode * 397) ^ (int) Status;
                hashCode = (hashCode * 397) ^ (Country != null ? Country.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (SelectedPreferences != null ? SelectedPreferences.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}