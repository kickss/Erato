using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sale.Controllers
{
    public class StaffController : BaseController
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
    }
}