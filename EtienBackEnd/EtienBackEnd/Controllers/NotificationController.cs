using System.Web.Http;
using System.Web.Http.Cors;
using Commands;
using dtos;

namespace EtienBackEnd.Controllers
{
    [RoutePrefix("api/notification")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class NotificationController : ApiController
    {
        [HttpPost]
        [Route("send")]
        public IHttpActionResult SendNotification(NotificationDTO NotificationToSend)
        {
            Command<bool> command = CommandFactory.GenerateSendMessageCommand(NotificationToSend);
            command.Execute();
            return Ok(true);
        }
    }
}
