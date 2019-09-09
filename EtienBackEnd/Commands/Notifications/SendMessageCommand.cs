using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Web.Script.Serialization;
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
        private string responseFromServer = "";


        public SendMessageCommand(NotificationDTO notificationDto)
        {
            NotificationDTO = notificationDto;
        }

        public override void Execute()
        {

            #region instrumentation

            _log.DebugFormat("Entrando a execute SendMessageCommand mensaje a enviar: {0} a la fecha {1}",NotificationDTO.NotificationTitle, DateTime.Now);

            #endregion

            FCMMessage fcmMessage = new FCMMessage(NotificationDTO);
            try
            {
                string authorizationToken = ConfigurationManager.AppSettings["FIREBASE_TOKEN"];
                string firebasePath = ConfigurationManager.AppSettings["FIREBASE_PATH"];
                string firebaseRequestType = ConfigurationManager.AppSettings["FIREBASE_REQUEST_TYPE"];
                string firebaseRequestContentType = ConfigurationManager.AppSettings["FIREBASE_REQUEST_CONTENT_TYPE"];
                WebRequest request = WebRequest.Create(firebasePath);
                request.Method = firebaseRequestType;
                request.ContentType = firebaseRequestContentType;
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string jsonFCMData = serializer.Serialize(fcmMessage);
                byte[] byteArray = Encoding.UTF8.GetBytes(jsonFCMData);
                request.Headers.Add($"Authorization: key={authorizationToken}");
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                WebResponse response = request.GetResponse();
                Stream dataStreamResponse = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStreamResponse);
                responseFromServer = reader.ReadToEnd();
                Param = true;
            }
            catch (Exception e)
            {
                _log.ErrorFormat("Error en el envio de notificacion, causa: {0}, respuesta de FCM: {1}", e.Message, responseFromServer);
                Param = false;
            }


            
        }
    }
}