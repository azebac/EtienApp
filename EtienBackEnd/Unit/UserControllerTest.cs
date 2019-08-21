

using System.Collections.Generic;
using System.Web.Http;
using dtos;
using enums;
using EtienBackEnd.Controllers;
using NUnit.Framework;

namespace Unit
{
    [TestFixture]
    public class UserControllerTest
    {
        [Test]
        public void CreateUserTest()
        {
            PreferenceDTO preferenceToTest = DTOFactory.CreatePreferenceDto(0,"Test");
            IList<PreferenceDTO> preferenceListToTest = new List<PreferenceDTO>();
            preferenceListToTest.Add(preferenceToTest);
            CountryDTO countryToTest = DTOFactory.CreateCountryDTO(0, "Test");

            UserDTO userToTest = DTOFactory.CreateUserDto(0, "Nombre prueba", "Apellido prueba", "usernamePrueba",
                "123456", "correo@correo.com", "1-555-555-555", UserGenderType.Male, UserStatusType.Active,
                countryToTest, preferenceListToTest);
            UserController controller = new UserController();
           IHttpActionResult result = controller.RegisterUser(userToTest);
           Assert.NotNull(result);
        }
    }
}
