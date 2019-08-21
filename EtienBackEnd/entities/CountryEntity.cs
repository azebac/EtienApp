using System.Collections;
using System.Collections.Generic;
using dtos;

namespace entities
{
    public class CountryEntity:Entity
    {
        public virtual string Name { get; set; }
        public virtual string ISO { get; set; }
        public virtual string NiceName { get; set; }
        public virtual string ISO3 { get; set; }
        public virtual int NumCode { get; set; }
        public virtual int PhoneCode { get; set; }
        public virtual IList<UserEntity> AssociatedUsers { get; set; } = new List<UserEntity>();

        public CountryEntity()
        {
        }

        public CountryEntity(long id, string name, string iso, string niceName, string iso3, int numCode, int phoneCode,
            IList<UserEntity> associatedUsers) : base(id)
        {
            Name = name;
            ISO = iso;
            NiceName = niceName;
            ISO3 = iso3;
            NumCode = numCode;
            PhoneCode = phoneCode;
            AssociatedUsers = associatedUsers;
        }

        public CountryEntity(long id, string name, IList<UserEntity> associatedUsers) : base(id)
        {
            Name = name;
            AssociatedUsers = associatedUsers;
        }

        public CountryEntity(CountryDTO country):base(country.Id)
        {
            Name = country.Name;
            ISO = country.ISO;
            NiceName = country.NiceName;
            ISO3 = country.ISO3;
            NumCode = country.NumCode;
            PhoneCode = country.PhoneCode;
        }

        protected bool Equals(CountryEntity other)
        {
            return string.Equals(Name, other.Name) && Equals(AssociatedUsers, other.AssociatedUsers);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CountryEntity) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = base.GetHashCode();
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (AssociatedUsers != null ? AssociatedUsers.GetHashCode() : 0);
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Name)}: {Name}, {nameof(AssociatedUsers)}: {AssociatedUsers}";
        }

        public virtual CountryDTO ConvertToDTO()
        {
            CountryDTO countryDTO = DTOFactory.CreateCountryDTO(Id, Name, ISO, NiceName, ISO3, NumCode, PhoneCode);
            return countryDTO;
        }
    }
}