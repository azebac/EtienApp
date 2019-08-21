using System.Web.Http;
using Commands;
using dtos;
using entities;

namespace EtienBackEnd.Controllers
{
    [RoutePrefix("api/users")]
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("register")]
        public IHttpActionResult RegisterUser(UserDTO user)
        {
            
            if (user == null)
                return BadRequest();
            UserEntity userToRegister = EntityFactory.CreateUserEntity(user);
            Command<UserEntity> commandRegisterUser = CommandFactory.GenerateCreateUserCommand(userToRegister);
            commandRegisterUser.Execute();
            return Ok(userToRegister);
        }
    }
}
