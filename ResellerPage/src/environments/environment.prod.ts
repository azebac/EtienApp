export const environment = {
  production: true,
  rest_path: {
    base:"http://localhost:/api",
    users:{
      base: "/users",      
    },
    login:{
      base:"",
      authenticate:"/login/adminAuthenticate"
    }
  }
};
