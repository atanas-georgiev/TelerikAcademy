﻿namespace Forum.Server.WebApi
{
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Routing;

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DatabaseConfig.Initialize();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

        }
    }
}
