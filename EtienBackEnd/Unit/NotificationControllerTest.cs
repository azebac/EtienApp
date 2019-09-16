using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using dtos;
using EtienBackEnd.Controllers;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Web.Script.Serialization;

namespace Unit
{
    [TestFixture]
    public class NotificationControllerTest:BaseTest
    {
        [Test]
        public void SendMessageTest()
        {
            PreferenceDTO preferenceToSend = DTOFactory.CreatePreferenceDto(1, "promociones");
            IList<PreferenceDTO> preferenceList = new List<PreferenceDTO>();
            preferenceList.Add(preferenceToSend);
            
            NotificationDTO notification =
                DTOFactory.CreateNotificationDto(null, preferenceList, "Prueba cuerpo", "prueba titulo", "prueba subtitulo");
            NotificationController controller = new NotificationController();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string jsonFCMData = serializer.Serialize(notification);
            IHttpActionResult result = controller.SendNotification(notification);
            OkNegotiatedContentResult<bool> contentResult = result as OkNegotiatedContentResult<bool>;
            Assert.NotNull(contentResult);

        }

    }
}