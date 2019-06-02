using System.Collections;
using System.Collections.Generic;

namespace entities
{
    public class CountryEntity:Entity
    {
        public virtual string Name { get; set; }
        public virtual IList<UserEntity> AssociatedUsers { get; set; }

        public CountryEntity()
        {
        }

        public CountryEntity(long id, string name, IList<UserEntity> associatedUsers) : base(id)
        {
            Name = name;
            AssociatedUsers = associatedUsers;
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
    }
}