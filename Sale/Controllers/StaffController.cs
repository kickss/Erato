using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data;
using System.IdentityModel;
using System.ServiceModel.Security;
using System.Web.Script.Serialization;

using Newtonsoft.Json;

using Sale.Entities;
using Sale.BLL;
using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Controllers
{
    public class StaffController : BaseController
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }

        #region "Danh mục Học viên"
        [HttpGet]
        public ActionResult DanhMucHocVien()
        {
            ViewBag.CurrentAction = "DanhMucHocVien";
            return View();
        }

        [HttpPost]
        public ActionResult DanhMucHocVien(FormCollection f)
        {
            return View();
        }
        #endregion

        #region "Dân tộc"
        public JsonResult Get_DANTOC()
        {
            clsDM_DANTOC objDanToc = new clsDM_DANTOC();
            DataTable _tbldsdantoc = objDanToc.GetAll();
            var sql = (from row in _tbldsdantoc.AsEnumerable()
                       select new
                       {
                           DANTOC_ID = row.Field<string>("DANTOC_ID"),
                           TEN_DANTOC = row.Field<string>("TEN_DANTOC")
                       }).AsQueryable();
            return Json(sql.ToList(), JsonRequestBehavior.AllowGet);
        }
        #endregion
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region "Tôn giáo"
        public JsonResult Get_TONGIAO()
        {
            clsSYS_DICTIONARY objTonGiao = new clsSYS_DICTIONARY();
            DataTable _tbldstongiao = objTonGiao.GetDictionaryByDictionary_Code("DM_TONGIAO");
            var sql = (from row in _tbldstongiao.AsEnumerable()
                       select new
                       {
                           TONGIAO_ID = row.Field<string>("TONGIAO_ID"),
                           TEN_TONGIAO = row.Field<string>("TEN_TONGIAO")
                       }).AsQueryable();
            return Json(sql.ToList(), JsonRequestBehavior.AllowGet);
        }
        #endregion
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region "Tỉnh, Thành phố"
        public JsonResult Get_PROVINCE()
        {
            clsDM_TINHTHANH objTinhThanh = new clsDM_TINHTHANH();
            DataTable _tbldsprovince = objTinhThanh.GetAll();
            var sql = (from row in _tbldsprovince.AsEnumerable()
                       select new
                       {
                           PROVINCE_ID = row.Field<string>("PROVINCE_ID"),
                           PROVINCE_NAME = row.Field<string>("PROVINCE_NAME"),
                           PROVINCE_TYPE = row.Field<string>("PROVINCE_TYPE")
                       }).AsQueryable();
            return Json(sql.ToList(), JsonRequestBehavior.AllowGet);
        }
        #endregion
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region "Quận, huyện"
        public JsonResult Get_District_By_Province()
        {
            clsDM_QUANHUYEN objQuanHuyen = new clsDM_QUANHUYEN();
            string PROVINCE_ID = Request["PROVINCE_ID"];
            DataTable _tbldsdistrict = objQuanHuyen.Get_District_By_Province(PROVINCE_ID);
            var sql = (from row in _tbldsdistrict.AsEnumerable()
                       select new
                       {
                           DISTRICT_ID = row.Field<string>("DISTRICT_ID"),
                           DISTRICT_NAME = row.Field<string>("DISTRICT_NAME"),
                           DISTRICT_TYPE = row.Field<string>("DISTRICT_TYPE"),
                           PROVINCE_ID = row.Field<string>("PROVINCE_ID")
                       }).AsQueryable();
            return Json(sql.ToList(), JsonRequestBehavior.AllowGet);
        }
        #endregion
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region "Phường, xã"
        public JsonResult Get_Ward_By_District()
        {
            clsDM_PHUONGXA objPhuongXa = new clsDM_PHUONGXA();
            string DISTRICT_ID = Request["DISTRICT_ID"];
            DataTable _tbldsward = objPhuongXa.Get_Ward_By_District(DISTRICT_ID);
            var sql = (from row in _tbldsward.AsEnumerable()
                       select new
                       {
                           WARD_ID = row.Field<string>("WARD_ID"),
                           WARD_NAME = row.Field<string>("WARD_NAME"),
                           WARD_TYPE = row.Field<string>("WARD_TYPE"),
                           DISTRICT_ID = row.Field<string>("DISTRICT_ID")
                       }).AsQueryable();
            return Json(sql.ToList(), JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}