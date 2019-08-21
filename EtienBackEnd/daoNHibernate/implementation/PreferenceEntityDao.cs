using entities;
using interfaces;
using NHibernate;

namespace daoNHibernate.implementation
{
    public class PreferenceEntityDao:BaseDao<PreferenceEntity>, IDaoPreferenceEntity
    {
        public PreferenceEntityDao(ISession session) : base(session)
        {
        }
    }
}