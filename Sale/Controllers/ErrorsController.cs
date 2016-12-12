using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data;
using System.IdentityModel;
using System.ServiceModel.Security;
using Newtonsoft.Json;
using Sale.BLL;
using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Controllers
{
    public class ErrorsController : Controller
    {
        // GET: Errors
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult General(Exception exception)
        {
            return View();
        }
        public ActionResult Http404()
        {
            Response.ContentType = "text/html";
            return View();
        }
        public ActionResult Http403()
        {
            Response.ContentType = "text/html";
            return View();
        }
    }
}