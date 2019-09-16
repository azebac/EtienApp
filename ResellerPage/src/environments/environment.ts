// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `.angular-cli.json`.

export const environment = {
  production: false,
  rest_path: {
    base:"http://localhost:53397/api",
    users:{
      base: "/users",
      getCountries:"/users/getCountries",
      getPreferences:"/users/getPreferences",
      getAllUsers:"/users/getUsers",
      getSpecificUser:"/users/consultUserById",
      updateUser:"/users/updateUser"
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
