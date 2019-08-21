using System.Reflection;
using daoNHibernate;
using entities;
using interfaces;
using log4net;

namespace Commands.Users
{
    public class SearchUserNicknameCommand:Command<UserEntity>
    {
        public override UserEntity Param { get; set; }
        private UserEntity UserToSearch { get; set; }
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public SearchUserNicknameCommand(UserEntity userToSearch)
        {
            UserToSearch = userToSearch;
        }

        public override void Execute()
        {

            #region instrumentation
                _log.DebugFormat("Entrando a execute SearchUserNicknameCommand usuario a buscar: {0}",UserToSearch.UserName);
            #endregion

            IDaoUserEntity dao = DaoNHbiernateFactory.FabricateUserEntityDao();
            Param = dao.searchUserByNickname(UserToSearch);

            #region instrumentation

            _log.DebugFormat("Saliendo execute SearchUserNicknameCommand completdo: {0}", Param.UserName);

            #endregion

        }
    }
}