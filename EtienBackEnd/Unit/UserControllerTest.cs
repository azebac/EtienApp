﻿using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using dtos;
using entities;
using enums;
using EtienBackEnd.Controllers;
using NUnit.Framework;

namespace Unit
{
    [TestFixture]
    public class UserControllerTest:BaseTest
    {
        [Test]
        public void CreateUserTest()
        {
            PreferenceDTO preferenceToTest = DTOFactory.CreatePreferenceDto(1, "promociones");
            IList<PreferenceDTO> preferenceListToTest = new List<PreferenceDTO>();
            preferenceListToTest.Add(preferenceToTest);
            CountryDTO countryToTest = DTOFactory.CreateCountryDTO(1);

            UserDTO userToTest = DTOFactory.CreateUserDto(0, "Nombre prueba", "Apellido prueba", "usernamePrueba2",
                "123456", "correo2@correo.com", "555555", UserGenderType.Male, UserStatusType.Active,
                countryToTest, preferenceListToTest);
            UserController controller = new UserController();
           IHttpActionResult result = controller.RegisterUser(userToTest);
           OkNegotiatedContentResult<UserEntity> contentResult = result as OkNegotiatedContentResult<UserEntity>;
           Assert.NotNull(contentResult);
           Assert.NotZero(contentResult.Content.Id);
         
        }

        [Test]
        public void LoginUserTest()
        {
            UserDTO userDto = DTOFactory.CreateUserDto(userName: "usernamePrueba", password: "123456");
            LoginController controller = new LoginController();
            IHttpActionResult result = controller.Authenticate(userDto);
            OkNegotiatedContentResult<UserDTO> contentResult = result as OkNegotiatedContentResult<UserDTO>;
            Assert.NotZero(contentResult.Content.Id);

        }

        [Test]
        public void GetAllUsersTest()
        {
            UserController controller = new UserController();
            IHttpActionResult result = controller.GetAllUsers();
            OkNegotiatedContentResult < IList < UserDTO >> contentResult = result as OkNegotiatedContentResult<IList<UserDTO>>;
            Assert.NotZero(contentResult.Content.Count);
        }

        [Test]
        public void GetUserByIdTest()
        {
            UserDTO userDTO = DTOFactory.CreateUserDto(3);
            UserController controller = new UserController();
            IHttpActionResult result = controller.GetUserById(userDTO);
            OkNegotiatedContentResult<UserDTO> contentResult = result as OkNegotiatedContentResult<UserDTO>;
            Assert.NotNull(contentResult.Content);

        }

        [Test]
        public void UpdateUserTest()
        {
            PreferenceDTO preferenceToTest = DTOFactory.CreatePreferenceDto(1, "Test");
            IList<PreferenceDTO> preferenceListToTest = new List<PreferenceDTO>();
            preferenceListToTest.Add(preferenceToTest);
            CountryDTO countryToTest = DTOFactory.CreateCountryDTO(1);

            UserDTO userToTest = DTOFactory.CreateUserDto(0, "Nombre pruebaEdit", "Apellido prueba", "usernamePrueba",
                "123456", "correo@correo.com", "1-555-555-555", UserGenderType.Male, UserStatusType.Banned,
                countryToTest, preferenceListToTest);



        }

        [Test]
        public void GetUserCountriesTest()
        {
            UserController controller = new UserController();
            IHttpActionResult result = controller.GetAllUserCountries();
            OkNegotiatedContentResult<IList<CountryDTO>> contentResult =
                result as OkNegotiatedContentResult<IList<CountryDTO>>;
            Assert.NotZero(contentResult.Content.Count);

        }

        [Test]
        public void GetPreferencesTest()
        {
            UserController controller = new UserController();
            IHttpActionResult result = controller.GetAllUserPreferences();
            OkNegotiatedContentResult<IList<PreferenceDTO>> contentResult =
                result as OkNegotiatedContentResult<IList<PreferenceDTO>>;
            Assert.NotZero(contentResult.Content.Count);

        }
    }
}
