using System;
using System.Reflection;
using daoNHibernate;
using entities;
using exceptions;
using interfaces;
using libraries;
using log4net;
using resources;

namespace Commands.Users
{
    public class ValidateLoginCommand:Command<UserEntity>
    {
        public override UserEntity Param { get; set; }
        private UserEntity UserLogginIn { get;  }
        private string JWTToken { get;  }
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public ValidateLoginCommand(UserEntity userLogginIn, string jwtToken)
        {
            UserLogginIn = userLogginIn;
            JWTToken = jwtToken;
        }

        public override void Execute()
        {

            #region Instrumentation

            _log.DebugFormat("Entrando a Execute ValidateLoginCommand usuario iniciando sesion: {0}", UserLogginIn.UserName);

            #endregion

            Command<UserEntity> searchUserInSystemCommand = CommandFactory.GenerateSearchUserNicknameCommand(UserLogginIn);
            searchUserInSystemCommand.Execute();
            UserEntity UserDataInBD = searchUserInSystemCommand.Param;
            Encryptor encryptor = new Encryptor();
            if (encryptor.CompareUserPasswords(UserLogginIn.Password, UserDataInBD.Password))
            {
                Param = UserDataInBD;
                Param.AppToken = JWTToken;
                IDaoUserEntity daoUser = DaoNHbiernateFactory.FabricateUserEntityDao();
                daoUser.Edit(Param);
            }
            else
            {
                throw new WrongPasswordException(ErrorCodes.WrongPassword,"Contraseña equivocada",new Exception("Contraseña Equivocada"));
            }

            #region Instrumentation

            _log.DebugFormat("Saliendo de Execute ValidateLoginCommand usuario iniciando sesion: {0}", UserLogginIn.UserName);

            #endregion
        }


    }
}