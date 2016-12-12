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
using Sale.Entities;
using Sale.BLL.DTO;

using NLog;
namespace Sale.Controllers
{
    public class LoginController : Controller
    {
        private Logger Mylogger = LogManager.GetCurrentClassLogger();

        clsDM_NHANVIEN clsNHANVIEN = new clsDM_NHANVIEN();
        SYS_BLL objBussinessLayer = new SYS_BLL();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            string UserName = f.Get("Username");
            string Password = f.Get("Password");
            if (UserName.Trim() != "" && Password.Trim() != "")
            {
                //--------------------------------------------------------------------------------------
                Mylogger.Info("Login To System : " + UserName.Trim() + "Pass: " + Password.Trim());
                clsResponseString objReturn = new clsResponseString();
                objReturn = objBussinessLayer.IsLoginSucess(UserName, Password);
                if (objReturn.ResultValue == clsConstant.CODE_SUCCESS)
                {
                    clsSYS_NHOMNGUOIDUNG objNhomNguoiDung= new clsSYS_NHOMNGUOIDUNG();
                    DataTable _tblUserMenu = objNhomNguoiDung.GetMenuBy_NhomNguoiDung(SaleGlobals.NHOMNGUOIDUNG_ID);
                    Session["STAFF_MENU"] = _tblUserMenu;
                    Session["NHANVIEN_ID"] = SaleGlobals.NHANVIEN_ID;
                    Session["IS_LOGIN"] = clsConstant.IS_AUTHENTICATION_SUCCESS;
                    Session["IS_ADMIN"] = SaleGlobals.NHOMNGUOIDUNG_ID;
                    
                    return RedirectToAction("DanhMucNhanVien", "Admin");
                }
                else
                {
                    SaleGlobals.Reset();
                    return RedirectToAction("Index", "Login");
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            objBussinessLayer.IsLogOutSucess(SaleGlobals.NHANVIEN_CODE);
            Session.RemoveAll();
            return RedirectToAction("Index", "Login");
        }
    }
}