using System.Reflection;
using dtos;
using entities;
using log4net;
using Newtonsoft.Json;

namespace Commands.Notifications
{
    public class SendMessageCommand:Command<bool>
    {
        public override bool Param { get; set; }
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private NotificationDTO NotificationDTO { get; set; }


        public SendMessageCommand(NotificationDTO notificationDto)
        {
            NotificationDTO = notificationDto;
        }

        public override void Execute()
        {
            FCMMessage fcmMessage = new FCMMessage(NotificationDTO);
            string jsonFCMData = JsonConvert.SerializeObject(fcmMessage);
        }
    }
}