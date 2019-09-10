using System.Collections.Generic;
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

        [HttpPost]
        [Route("getUsers")]
        public IHttpActionResult GetAllUsers()
        {
            Command<IList<UserEntity>> commandGetUsers = CommandFactory.GenerateGetAllUsersCommand();
            commandGetUsers.Execute();
            IList<UserDTO> fetchedUsers = new List<UserDTO>();
            foreach (UserEntity fetchedUser in commandGetUsers.Param)
            {
                fetchedUsers.Add(fetchedUser.ConvertToDTO());
            }
            return Ok(fetchedUsers);
        }

        [HttpPost]
        [Route("consultUserById")]
        public IHttpActionResult GetUserById(UserDTO filterUser)
        {
            UserEntity userToSearch = EntityFactory.CreateUserEntity(filterUser);
            Command<UserEntity> commandSearchUser = CommandFactory.GenerateGetUserByIdCommand(userToSearch);
            commandSearchUser.Execute();
            UserDTO resultUser = commandSearchUser.Param.ConvertToDTO();
            return Ok(resultUser);
        }

        [HttpPost]
        [Route("updateUser")]
        public IHttpActionResult UpdateUser(UserDTO newData)
        {
            UserEntity userToUpdate = EntityFactory.CreateUserEntity(newData);
            Command<UserEntity> commandUpdateUser = CommandFactory.GenerateUpdateUserCommand(userToUpdate);
            commandUpdateUser.Execute();
            UserDTO resultUser = commandUpdateUser.Param.ConvertToDTO();
            return Ok(resultUser);
        }

        [HttpPost]
        [Route("getCountries")]
        public IHttpActionResult GetAllUserCountries()
        {
            Command<IList<CountryDTO>> command = CommandFactory.GenerateGetUsersCountriesCommand();
            command.Execute();
            return Ok(command.Param);
        }

        [HttpPost]
        [Route("getPreferences")]
        public IHttpActionResult GetAllUserPreferences()
        {
            Command<IList<PreferenceDTO>> command = CommandFactory.GenerateGetUsersPreferencesCommand();
            command.Execute();
            return Ok(command.Param);
        }
    }
}
