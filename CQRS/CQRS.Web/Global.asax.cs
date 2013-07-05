﻿using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace CQRS.Web
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}