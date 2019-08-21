using System.Collections.Generic;
using dtos;

namespace entities
{
    public class PreferenceEntity:Entity
    {
        public virtual string Name { get; set; }

        public virtual IList<UserEntity> AssociatedUsers {
            get;
            set;
        }

        public PreferenceEntity()
        {
        }

        public PreferenceEntity(long id, string name, IList<UserEntity> associatedUsers) : base(id)
        {
            Name = name;
            AssociatedUsers = associatedUsers;
        }

        public PreferenceEntity(PreferenceDTO preference) : base(preference.Id)
        {
            Name = preference.Name;
        }
        

        protected bool Equals(PreferenceEntity other)
        {
            return string.Equals(Name, other.Name) && Equals(AssociatedUsers, other.AssociatedUsers);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PreferenceEntity) obj);
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

        public virtual PreferenceDTO ConvertToDTO()
        {
            PreferenceDTO preferenceDto = DTOFactory.CreatePreferenceDto(Id, Name);
            return preferenceDto;
        }
    }
}