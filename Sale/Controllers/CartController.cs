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
    public class CartController : BaseController
    {
        // GET: Cart
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            return View();
        }
    }
}