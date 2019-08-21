using System;
using System.Data.SqlClient;
using System.Reflection;
using entities;
using exceptions;
using interfaces;
using log4net;
using NHibernate;
using resources;
namespace daoNHibernate.implementation
{
    public class UserEntityDao: BaseDao<UserEntity>, IDaoUserEntity
    {

        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public UserEntityDao(ISession session) : base(session)
        {
        }

        public UserEntity searchUserByNickname(UserEntity user)
        {

            #region instrumentation

            _log.DebugFormat("Entrando searchUserByNickname: param {0} ", user.UserName);

            #endregion

            UserEntity resultUser = null;

            try
            {
                resultUser = _session.QueryOver<UserEntity>().Where(x => x.UserName == user.UserName).SingleOrDefault();
                if (resultUser != null)
                    user = resultUser;
                else
                {
                    throw new UsernameNotFoundException(ErrorCodes.UsernameNotFound,"Usuario no encontrado",new Exception("Usuario no encontrado"));
                }
            }
            catch (SqlException e)
            {
                #region instrumentation

                _log.ErrorFormat("Error sql ocurrido en searchUserByNickname tipo {0}, mensaje {1}, causa {2}",e,e.Message,e.TargetSite);

                #endregion

                throw;
            }
            catch (Exception e)
            {
                #region instrumentation
            
                _log.ErrorFormat("Error ocurrido en searchUserByNickname tipo {0}, mensaje {1}, causa {2}", e, e.Message, e.TargetSite);
                
                #endregion

                throw;
            }

            return user;

        }
    }
}