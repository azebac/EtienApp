using System;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Threading.Tasks;
using daoNHibernate;
using log4net;
using entities;
using interfaces;
using System.Configuration;
using libraries;

namespace Commands.Users
{
    public class CreateUserCommand:Command<UserEntity>
    {
        private UserEntity UserToRegister { get; set; }
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public override UserEntity Param { get; set; }
        

        public CreateUserCommand(UserEntity userToRegister)
        {
            #region Instrumentation

            _log.DebugFormat("Entrando a CTOR CreateUserCommand usuario a registrar: {0}",userToRegister);

            #endregion

            UserToRegister = userToRegister;

            #region Instrumentation

            _log.DebugFormat("Saliendo CTOR CreateUserCommand");

            #endregion
        }

        public override void Execute()
        {
            #region Instrumentation

            _log.Debug("Entrando Execute CreateUserCommand");

            #endregion

            IDaoUserEntity dao = DaoNHbiernateFactory.FabricateUserEntityDao();
            Encryptor encryptor = new Encryptor();
            UserToRegister.Password = encryptor.GenerateEncryptedPassword(UserToRegister.Password);
            Param = dao.Add(UserToRegister);

            #region Instrumentation

            _log.DebugFormat("Saliendo de Execute CreateUserCommand resultado: {0}", Param);

            #endregion
        }
        


    }
}