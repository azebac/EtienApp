using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dtos;

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
            return Ok(user);
        }
    }
}
