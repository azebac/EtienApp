using System.Collections.Generic;
using System.Reflection;
using daoNHibernate;
using entities;
using interfaces;
using log4net;

namespace Commands.Users
{
    public class GetAllUsersCommand:Command<IList<UserEntity>>
    {
        public override IList<UserEntity> Param { get; set; }
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public GetAllUsersCommand()
        {
        }

        public override void Execute()
        {
            #region Instrumentation

            _log.DebugFormat("Entrando a execute GetAllUsersCommand");

            #endregion

            IDaoUserEntity dao = DaoNHbiernateFactory.FabricateUserEntityDao();
            Param = dao.GetAll();

            #region Instrumentation

            _log.DebugFormat("Saliendo de execute GetAllUsersCommand");

            #endregion
            
        }
    }
}