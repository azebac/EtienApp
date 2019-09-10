using daoNHibernate.implementation;
using libraries;

namespace daoNHibernate
{
    public class DaoNHbiernateFactory
    {
        public static UserEntityDao FabricateUserEntityDao()
        {
            return new UserEntityDao(GlobalRegistry.GetInstance().Session);
        }

        public static PreferenceEntityDao FabricatePreferenceEntityDao()
        {
            return new PreferenceEntityDao(GlobalRegistry.GetInstance().Session);
        }

        public static CountryEntityDao FabricateCountryEntityDao()
        {
            return new CountryEntityDao(GlobalRegistry.GetInstance().Session);
        }
    }
}
