using System.Web.Http;
using Commands;
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
            Command<bool> command = CommandFactory.GenerateSendMessageCommand(NotificationToSend);
            command.Execute();
            return Ok(true);
        }
    }
}
