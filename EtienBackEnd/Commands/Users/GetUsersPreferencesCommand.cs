using System.Collections.Generic;
using System.Reflection;
using daoNHibernate;
using daoNHibernate.implementation;
using dtos;
using entities;
using log4net;

namespace Commands.Users
{
    public class GetUsersPreferencesCommand:Command<IList<PreferenceDTO>>
    {
        public override IList<PreferenceDTO> Param { get; set; }
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);


        public GetUsersPreferencesCommand()
        {
        }

        public override void Execute()
        {
            #region instrumentation

            _log.DebugFormat("Entrando a GetUsersPreferencesCommand");

            #endregion

            PreferenceEntityDao dao = DaoNHbiernateFactory.FabricatePreferenceEntityDao();
            IList<PreferenceEntity> list = dao.GetAll();
            Param = new List<PreferenceDTO>();
            if (list != null)
            {
                foreach (PreferenceEntity preference in list)
                {
                    Param.Add(preference.ConvertToDTO());
                }
            }
        }
    }
}