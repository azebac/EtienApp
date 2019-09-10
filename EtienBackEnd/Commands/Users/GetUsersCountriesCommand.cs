using System.Collections.Generic;
using System.Reflection;
using daoNHibernate;
using daoNHibernate.implementation;
using dtos;
using entities;
using log4net;

namespace Commands.Users
{
    public class GetUsersCountriesCommand:Command<IList<CountryDTO>>
    {
        public override IList<CountryDTO> Param { get; set; }
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);


        public GetUsersCountriesCommand()
        {
        }

        public override void Execute()
        {
            #region Instrumentation

            _log.DebugFormat("Entrando Execute GetUsersCountriesCommand");

            #endregion

            CountryEntityDao dao = DaoNHbiernateFactory.FabricateCountryEntityDao();
            IList<CountryEntity> countries = dao.GetAll();
            Param = new List<CountryDTO>();
            if (countries != null)
            {
                foreach (CountryEntity country in countries)
                {
                    Param.Add(country.ConvertToDTO());
                }
            }

            
        }
    }
}