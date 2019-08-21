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

namespace Commands.Users
{
    public class CreateUserCommand:Command<UserEntity>
    {
        private UserEntity UserToRegister { get; set; }
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public override UserEntity Param { get; set; }
        private static int saltLengthLimit = int.Parse(ConfigurationManager.AppSettings["PasswordSaltLenght"]);

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
            EncryptPassword(UserToRegister);
            Param = dao.Add(UserToRegister);

            #region Instrumentation

            _log.DebugFormat("Saliendo de Execute CreateUserCommand resultado: {0}", Param);

            #endregion
        }

        private void EncryptPassword(UserEntity userToRegister)
        {
            #region instrumentation
            _log.DebugFormat("Encriptando el password del usuario {0}", userToRegister.UserName);
            #endregion
            
            byte[] salt = GetSalt();
            Rfc2898DeriveBytes encrypter = new Rfc2898DeriveBytes(userToRegister.Password, salt, 10000);
            byte[] hash = encrypter.GetBytes(20);
            byte[] hashBytes = new byte[52];
            Array.Copy(salt, 0,hashBytes,0,32);
            Array.Copy(hash, 0,hashBytes, 32,20);
            userToRegister.Password = Convert.ToBase64String(hashBytes);

            #region Instrumentation

            _log.Debug("Encriptado de password completado");

            #endregion
            
        }

        
        private byte[] GetSalt()
        {
            return GetSalt(saltLengthLimit);
        }

        private byte[] GetSalt(int maximumSaltLength)
        {
            byte[] salt = new byte[maximumSaltLength];
            using (RNGCryptoServiceProvider random = new RNGCryptoServiceProvider())
            {
                random.GetNonZeroBytes(salt);
            }

            return salt;
        }

    }
}