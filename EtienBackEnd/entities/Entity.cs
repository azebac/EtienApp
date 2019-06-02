using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public class Entity
    {

        private long _id;
        public virtual long Id
        {
            get => _id;
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException($"{nameof(_id)}: {_id.ToString()}");
                _id = value;
            }
        }

        public Entity()
        {
        }

        public Entity(long id)
        {
            Id = id;
        }

        protected bool Equals(Entity other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return _id == other._id;
        }

        /// <summary>
        /// Function that transforms an object into a hashed code
        /// </summary>
        /// <returns>
        /// Object in a hashed code integer
        /// </returns
        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }

        /// <summary>
        /// Function for transforming an object into a string
        /// </summary>
        /// <returns>
        /// Object to string
        /// </returns>
        public override string ToString()
        {
            return $"{nameof(_id)}: {_id.ToString()}";
        }
    }
}
