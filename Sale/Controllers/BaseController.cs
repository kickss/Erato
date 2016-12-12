using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Text;
using System.Configuration;

using Newtonsoft.Json;
using NLog;

using Sale.UTILITIES;
using Sale.DAL;
using Sale.BLL;
using System.Web.Routing;

namespace Sale.Controllers
{
    public class BaseController : Controller
    {
        public string _userSession { set; get; }
        protected Logger Mylogger { get; private set; }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpSessionStateBase session = filterContext.HttpContext.Session;
            string CurrentController = HttpContext.Request.RequestContext.RouteData.Values["controller"].ToString();
            string CurrentAction = HttpContext.Request.RequestContext.RouteData.Values["Action"].ToString();

            if (Session["NHANVIEN_ID"] != null || Session["STAFF_MENU"] != null || Session["IS_LOGIN"] != null)
            {
                if (int.Parse(Session["IS_ADMIN"].ToString()) == 1)
                {
                    return;
                }
                else if (int.Parse(Session["IS_ADMIN"].ToString()) == 3)
                {
                    if (CurrentController.ToUpper() != "HOME" || CurrentController.ToUpper() != "CART" || CurrentController.ToUpper() != "PRODUCT" || CurrentController.ToUpper() != "STAFF")
                    {
                        filterContext.Result = new RedirectToRouteResult(
                            new RouteValueDictionary {
                        { "Controller", "Errors" },
                        { "Action", "Http403" }
                        });
                        return;
                    }
                }
                else
                {
                    if (CurrentController.ToUpper() != "HOME" || CurrentController.ToUpper() != "CART" || CurrentController.ToUpper() != "PRODUCT")
                    {
                        filterContext.Result = new RedirectToRouteResult(
                            new RouteValueDictionary {
                        { "Controller", "Errors" },
                        { "Action", "Http403" }
                        });
                        return;
                    }
                }
            }
            else
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary {
                        { "Controller", "Login" },
                        { "Action", "Index" }
                        });
                return;
            }
        }

        public BaseController()
        {

        }
    }
}