using System.Reflection;
using daoNHibernate;
using entities;
using interfaces;
using log4net;

namespace Commands.Users
{
    public class GetUserByIdCommand:Command<UserEntity>
    {
        public override UserEntity Param { get; set; }
        public UserEntity UserToSearch { get; set; }
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public GetUserByIdCommand(UserEntity userToSearch)
        {
            #region Instrumentation

            _log.DebugFormat("Entrando CTO GetUserByIdCommand usuario a buscar: {0}",userToSearch.Id);

            #endregion
            UserToSearch = userToSearch;
            #region Instrumentation

            _log.DebugFormat("Saliendo de ctor GetUserByIdCommand");

            #endregion
        }


        public override void Execute()
        {
            #region Instrumentation

            _log.DebugFormat("Entrando execute GetUserByIdCommand");

            #endregion

            IDaoUserEntity dao = DaoNHbiernateFactory.FabricateUserEntityDao();
            Param = dao.GetById(UserToSearch.Id);

            #region Instrumentation

            _log.DebugFormat("Saliendo de execute GetUserByIdCommand usuario encontrado: {0}", Param);

            #endregion
        }
    }
}