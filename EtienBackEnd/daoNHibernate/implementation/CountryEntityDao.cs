using entities;
using interfaces;
using NHibernate;

namespace daoNHibernate.implementation
{
    public class CountryEntityDao:BaseDao<CountryEntity>, IDaoCountryEntity
    {
        public CountryEntityDao(ISession session) : base(session)
        {
        }
    }
}