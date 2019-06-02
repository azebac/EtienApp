using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using daoNHibernate.implementation;
using libraries;
using NHibernate;

namespace EtienBackEnd
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        internal static ISessionFactory SessionFactory = FluentNHibernateHelper.CreateFactorySession();

        protected void Application_Start()
        {
            GlobalRegistry.GetInstance();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            GlobalRegistry.GetInstance().Session = SessionFactory.OpenSession();
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            if (GlobalRegistry.GetInstance().Session != null &&
                GlobalRegistry.GetInstance().Session.IsOpen)
            {
                GlobalRegistry.GetInstance().Session.Dispose();
            }
        }
    }
}
