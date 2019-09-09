using System.Web.Http;
using dtos;

namespace EtienBackEnd.Controllers
{
    [RoutePrefix("api/notification")]
    public class NotificationController : ApiController
    {
        [HttpPost]
        [Route("send")]
        public IHttpActionResult SendNotification(NotificationDTO NotificationToSend)
        {
            return Ok(true);
        }
    }
}
