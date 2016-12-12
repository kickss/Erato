using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Sale.Controllers;

namespace Sale
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_PostAuthorizeRequest()
        {
            System.Web.HttpContext.Current.SetSessionStateBehavior(System.Web.SessionState.SessionStateBehavior.Required);
        }

        void Session_Start(object sender, EventArgs e)
        {
        }

        protected void Application_Error()
        {
            //var exception = Server.GetLastError();
            //var httpException = exception as HttpException;
            //Response.Clear();
            //Server.ClearError();
            //var routeData = new RouteData();
            //routeData.Values["controller"] = "Errors";
            //routeData.Values["action"] = "General";
            //routeData.Values["exception"] = exception;
            //Response.StatusCode = 500;
            //if (httpException != null)
            //{
            //    Response.StatusCode = httpException.GetHttpCode();
            //    switch (Response.StatusCode)
            //    {
            //        case 403:
            //            routeData.Values["action"] = "Http403";
            //            break;
            //        case 404:
            //            routeData.Values["action"] = "Http404";
            //            break;
            //    }
            //}
            //IController errorsController = new ErrorsController();
            //var rc = new RequestContext(new HttpContextWrapper(Context), routeData);
            //errorsController.Execute(rc);
        }
    }
}
