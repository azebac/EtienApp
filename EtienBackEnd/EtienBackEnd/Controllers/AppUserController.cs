using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EtienBackEnd.Controllers
{

    [Authorize]
    [RoutePrefix("api/appuser")]
    public class AppUserController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetId(int id)
        {
            string customerFake = "customer-fake";
            return Ok(customerFake);
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            string[] customersFake = new string[] { "customer-1", "customer-2", "customer-3" };
            return Ok(customersFake);
        }
    }
}
