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
    public class ProductController : BaseController
    {
        // GET: Product
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

        [HttpGet]
        public ActionResult ProductDetail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProductDetail(FormCollection f)
        {
            return View();
        }
    }
}