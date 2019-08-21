﻿
using System.Net;
using System.Reflection;
using System.Threading;
using System.Web.Http;
using Commands;
using dtos;
using entities;
using exceptions;
using EtienBackEnd.Models;
using log4net;

namespace EtienBackEnd.Controllers
{
    /// <summary>
    /// login controller class for authenticate users
    /// </summary>
    [AllowAnonymous]
    [RoutePrefix("api/login")]
    public class LoginController : ApiController
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [HttpGet]
        [Route("echoping")]
        public IHttpActionResult EchoPing()
        {
            return Ok(true);
        }

        [HttpGet]
        [Route("echouser")]
        public IHttpActionResult EchoUser()
        {
            var identity = Thread.CurrentPrincipal.Identity;
            return Ok($" IPrincipal-user: {identity.Name} - IsAuthenticated: {identity.IsAuthenticated}");
        }

        [HttpPost]
        [Route("authenticate")]
        public IHttpActionResult Authenticate(UserDTO login)
        {

            UserEntity userLogginIn = EntityFactory.CreateUserEntity(login);
            string token = TokenGenerator.GenerateTokenJwt(login.UserName);
            Command<UserEntity> loginCommand = CommandFactory.GenerateValidateLoginCommand(userLogginIn,token);
            UserDTO responseUser = null;
            try
            {
                loginCommand.Execute();
                userLogginIn = loginCommand.Param;
                responseUser = userLogginIn.ConvertToDTO();

            }
            catch (WrongPasswordException e)
            {

                #region instrumentation
                _log.ErrorFormat("Error en login de {0} producido por: {1}",login.UserName,e.InnerMessage);
                #endregion

                Unauthorized();
            }
            catch (UsernameNotFoundException e)
            {

                #region instrumentation
                _log.ErrorFormat("Error en login de {0} producido por: {1}", login.UserName, e.InnerMessage);
                #endregion

                Unauthorized();
            }
            return Ok(responseUser);
        }
    }
}
