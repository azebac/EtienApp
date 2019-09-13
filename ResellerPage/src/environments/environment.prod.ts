export const environment = {
  production: true,
  rest_path: {
    base:"http://localhost:53397/api",
    users:{
      base: "/users",
      getCountries:"/users/getCountries",
      getPreferences:"/users/getPreferences"
    },
    login:{
      base:"/login",
      authenticate:"/login/adminAuthenticate"
    },
    notification:{
      base:"/notification",
      sendNotification:"/notification/send"
    }
  }
};
