using entities;
using interfaces;
using NHibernate;

namespace daoNHibernate.implementation
{
    public class UserEntityDao: BaseDao<UserEntity>, IDaoUserEntity
    {
        public UserEntityDao(ISession session) : base(session)
        {
        }
    }
}