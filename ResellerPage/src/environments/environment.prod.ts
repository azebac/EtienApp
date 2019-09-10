export const environment = {
  production: false,
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
    }
  }
};