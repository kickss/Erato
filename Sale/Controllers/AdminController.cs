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
    [NoCache]
    public class AdminController : BaseController
    {
        #region Khai báo
        clsSYS_QUYEN clsQuyen = new clsSYS_QUYEN();
        clsSYS_NHOMNGUOIDUNG clsNHOMNGUOIDUNG = new clsSYS_NHOMNGUOIDUNG();
        clsDM_CHUCVU clsCHUCVU = new clsDM_CHUCVU();
        clsDM_PHONGBAN clsPHONGBAN = new clsDM_PHONGBAN();
        clsDM_NHANVIEN clsNHANVIEN = new clsDM_NHANVIEN();
        clsCommon clsCommon = new clsCommon();
        //clsMiscellaneous clsMiscellaneous = new clsMiscellaneous();
        #endregion

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        #region -- Cấu hình Menu
        [HttpGet]
        public ActionResult DinhNghiaDanhMuc()
        {
            ViewBag.CurrentAction = "DinhNghiaDanhMuc";
            return View();
        }

        [HttpPost]
        public ActionResult DinhNghiaDanhMuc(FormCollection f)
        {
            bool IsSuccess = false;
            string LOAI = Request["LOAI"];
            DataAccess m_Dal = new DataAccess();
            clsSYS_QUYEN clsQUYEN = new clsSYS_QUYEN(m_Dal);
            if (LOAI == "INSERT_CHA")
            {
                string MAQUYEN = Request["MAQUYEN"];
                string TENQUYEN = Request["TENQUYEN"];
                Int32 STT = Int32.Parse(Request["STT"]);
                bool ENABLE = bool.Parse(Request["ENABLE"]);
                m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                clsQUYEN.MAQUYEN = MAQUYEN.TrimStart().TrimEnd() + "*" + TENQUYEN.TrimStart().TrimEnd();
                clsQUYEN.TENQUYEN = TENQUYEN;
                clsQUYEN.STT = STT;
                clsQUYEN.ENABLE = ENABLE;
                clsQUYEN.QUYEN_CHA_ID = 0;
                clsQUYEN.MA_QUYEN_CHA = "CHA*Danh mục cha";
                IsSuccess = clsQUYEN.Add();
                if (IsSuccess)
                {
                    m_Dal.CommitTrans(true);
                    return Content("...");
                }
                else
                {
                    m_Dal.AbortTrans();
                    return Content("Tạo Menu Cha thất bại!");
                }
            }
            else if (LOAI == "INSERT_CON")
            {
                string MAQUYEN = Request["MAQUYEN"];
                string MA_QUYEN_CHA = Request["MA_QUYEN_CHA"];
                string TENQUYEN = Request["TENQUYEN"];
                string DUONGDAN = Request["DUONGDAN"];
                Int32 QUYEN_CHA_ID = Int32.Parse(Request["QUYEN_CHA_ID"]);
                Int32 STT = Int32.Parse(Request["STT"]);
                bool ENABLE = bool.Parse(Request["ENABLE"]);
                m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                clsQUYEN.MAQUYEN = MAQUYEN;
                clsQUYEN.TENQUYEN = TENQUYEN;
                clsQUYEN.DUONGDAN = DUONGDAN;
                clsQUYEN.ENABLE = ENABLE;
                clsQUYEN.QUYEN_CHA_ID = QUYEN_CHA_ID;
                clsQUYEN.MA_QUYEN_CHA = MA_QUYEN_CHA.TrimStart().TrimEnd();
                clsQUYEN.STT = STT;
                IsSuccess = clsQUYEN.Add();
                if (IsSuccess)
                {
                    m_Dal.CommitTrans(true);
                    return Content("...");
                }
                else
                {
                    m_Dal.AbortTrans();
                    return Content("Tạo Menu Con thất bại!");
                }
            }
            else if (LOAI == "UPDATE_MENU")
            {
                int QUYEN_ID = int.Parse(Request["QUYEN_ID"]);
                string TENQUYEN = Request["TENQUYEN"];
                int STT = int.Parse(Request["STT"]);
                string DUONGDAN = Request["DUONGDAN"];
                bool ENABLE = bool.Parse(Request["ENABLE"]);
                m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                clsQUYEN.QUYEN_ID = QUYEN_ID;
                clsQUYEN.TENQUYEN = TENQUYEN;
                clsQUYEN.DUONGDAN = DUONGDAN;
                clsQUYEN.ENABLE = ENABLE;
                clsQUYEN.STT = STT;
                IsSuccess = clsQUYEN.Update();
                if (IsSuccess)
                {
                    m_Dal.CommitTrans(true);
                    return Content("...");
                }
                else
                {
                    m_Dal.AbortTrans();
                    return Content("Cập nhật Menu thất bại!");
                }
            }
            else if (LOAI == "XOA_MENU_CON")
            {
                int QUYEN_ID = int.Parse(Request["QUYEN_ID"]);
                m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                IsSuccess = clsQUYEN.Delete(QUYEN_ID);
                if (IsSuccess)
                {
                    m_Dal.CommitTrans(true);
                    return Content("...");
                }
                else
                {
                    m_Dal.AbortTrans();
                    return Content("Xóa Menu Con thất bại!");
                }
            }
            else if (LOAI == "XOA_MENU_CHA")
            {
                int QUYEN_ID = int.Parse(Request["QUYEN_ID"]);
                m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                IsSuccess = clsQUYEN.DeleteMenuCha(QUYEN_ID);
                if (IsSuccess)
                {
                    m_Dal.CommitTrans(true);
                    return Content("...");
                }
                else
                {
                    m_Dal.AbortTrans();
                    return Content("Xóa Menu Cha thất bại!");
                }
            }
            else
            {
                if (IsSuccess)
                {
                    m_Dal.CommitTrans(true);
                    return Content("...");
                }
                else
                {
                    m_Dal.AbortTrans();
                    return Content("Tạo Menu thất bại!");
                }
            }
        }

        public JsonResult Get_Menu_Cha()
        {
            DataTable _tblMenuCha = clsQuyen.GetAll_Menu_Cha();
            var sql = (from row in _tblMenuCha.AsEnumerable()
                       select new
                       {
                           QUYEN_ID = row.Field<int>("QUYEN_ID"),
                           MAQUYEN = row.Field<string>("MAQUYEN"),
                           TENQUYEN = row.Field<string>("TENQUYEN"),
                           STT = row.Field<int>("STT")
                       }).AsQueryable();
            return Json(sql.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Get_DS_Menu()
        {
            DataTable _tbldsmenu = clsQuyen.GetAll();
            var sql = (from row in _tbldsmenu.AsEnumerable()
                       select new
                       {
                           QUYEN_ID = row.Field<int>("QUYEN_ID"),
                           MAQUYEN = row.Field<string>("MAQUYEN") == null ? "" : row.Field<string>("MAQUYEN"),
                           TENQUYEN = row.Field<string>("TENQUYEN"),
                           QUYEN_CHA_ID = row.Field<int>("QUYEN_CHA_ID"),
                           MA_QUYEN_CHA = row.Field<string>("MA_QUYEN_CHA") == null ? "" : row.Field<string>("MA_QUYEN_CHA"),
                           ENABLE = row.Field<bool>("ENABLE"),
                           DUONGDAN = row.Field<string>("DUONGDAN") == null ? "" : row.Field<string>("DUONGDAN"),
                           STT = row.Field<int>("STT")
                       }).AsQueryable();
            return Json(sql.ToList(), JsonRequestBehavior.AllowGet);
        }
        #endregion

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Quản Trị Người Dùng
         [HttpGet]
        public ActionResult QuanLyNguoiDung()
        {
            ViewBag.CurrentAction = "QuanLyNguoiDung";
            return View();
        }

         [HttpPost]
         public ActionResult QuanLyNguoiDung(FormCollection f)
         {
             return Content("...");
         }
        #endregion
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region "Nhóm quyền"
         [HttpGet]
         public ActionResult DanhMucNhomQuyen()
         {
             ViewBag.CurrentAction = "DanhMucNhomQuyen";
             return View();
         }

         [HttpPost]
         public ActionResult DanhMucNhomQuyen(FormCollection f)
         {
             return View();
         }

         [HttpPost]
         public ActionResult TaoNhomNguoiDung()
         {
             string MANHOMND = Request["MANHOMND"];
             string TENNHOMND = Request["TENNHOMND"];

             DataAccess m_Dal = new DataAccess();
             clsSYS_NHOMNGUOIDUNG clsNHOMNGUOIDUNG = new clsSYS_NHOMNGUOIDUNG(m_Dal);
             m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
             clsNHOMNGUOIDUNG.NHOMNGUOIDUNG_CODE = MANHOMND;
             clsNHOMNGUOIDUNG.TENNHOMNGUOIDUNG = TENNHOMND;
             bool IsSuccess = clsNHOMNGUOIDUNG.Add();
             if (IsSuccess)
             {
                 m_Dal.CommitTrans(true);
                 return Content("...");
             }
             else
             {
                 m_Dal.AbortTrans();
                 return Content("Tạo nhóm người dùng thất bại!");
             }
         }

         [HttpPost]
         public ActionResult CapNhatNDD()
         {
             int NDD_ID = int.Parse(Request["NDD_ID"]);
             string MANHOMND = Request["MANHOMND"];
             string TENNHOMND = Request["TENNHOMND"];

             DataAccess m_Dal = new DataAccess();
             clsSYS_NHOMNGUOIDUNG clsNHOMNGUOIDUNG = new clsSYS_NHOMNGUOIDUNG(m_Dal);
             m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
             clsNHOMNGUOIDUNG.NHOMNGUOIDUNG_ID = NDD_ID;
             clsNHOMNGUOIDUNG.NHOMNGUOIDUNG_CODE = MANHOMND;
             clsNHOMNGUOIDUNG.TENNHOMNGUOIDUNG = TENNHOMND;
             bool IsSuccess = clsNHOMNGUOIDUNG.Update();
             if (IsSuccess)
             {
                 m_Dal.CommitTrans(true);
                 return Content("...");
             }
             else
             {
                 m_Dal.AbortTrans();
                 return Content("Cập nhật nhóm người dùng thất bại!");
             }
         }

         [HttpPost]
         public ActionResult XoaNDD()
         {
             int NDD_ID = int.Parse(Request["NDD_ID"]);

             DataAccess m_Dal = new DataAccess();
             clsSYS_NHOMNGUOIDUNG clsNHOMNGUOIDUNG = new clsSYS_NHOMNGUOIDUNG(m_Dal);
             clsSYS_NHOMNGUOIDUNG_QUYEN clsMiscellaneous = new clsSYS_NHOMNGUOIDUNG_QUYEN(m_Dal);
             m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
             bool IsSuccess = clsMiscellaneous.DeleteQuyenByNhomNguoiDung(NDD_ID);
             if (IsSuccess)
             {
                 IsSuccess = clsNHOMNGUOIDUNG.Delete(NDD_ID);
             }

             if (IsSuccess)
             {
                 m_Dal.CommitTrans(true);
                 return Content("...");
             }
             else
             {
                 m_Dal.AbortTrans();
                 return Content("Xóat nhóm người dùng thất bại!");
             }
         }

         [HttpPost]
         public ActionResult UpdateQuyen()
         {
             Int32 NHOMNGUOIDUNG_ID = Int32.Parse(Request["NHOMNGUOIDUNG_ID"].ToString());
             string quyenTemp = Request["QUYEN"].ToString();
             string[] dsquyen = quyenTemp.Split(',');

             DataAccess m_Dal = new DataAccess();
             clsSYS_NHOMNGUOIDUNG_QUYEN objNhomNguoiDung_Quyen = new clsSYS_NHOMNGUOIDUNG_QUYEN(m_Dal);
             m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
             bool IsSuccess = objNhomNguoiDung_Quyen.DeleteQuyenByNhomNguoiDung(NHOMNGUOIDUNG_ID);
             if (IsSuccess)
             {
                 for (int i = 0; i < dsquyen.Length; i++)
                 {
                     objNhomNguoiDung_Quyen.NHOMNGUOIDUNG_ID = NHOMNGUOIDUNG_ID;
                     objNhomNguoiDung_Quyen.QUYEN_ID = Int32.Parse(dsquyen[i]);
                     IsSuccess = objNhomNguoiDung_Quyen.Add();
                     if (!IsSuccess)
                         break;
                 }
             }
             if (IsSuccess)
             {
                 m_Dal.CommitTrans(true);
                 return Content("...");
             }
             else
             {
                 m_Dal.AbortTrans();
                 return Content("Xóat nhóm người dùng thất bại!");
             }
         }

         public JsonResult Get_DS_NhomNguoiDung()
         {
             DataTable _tbldsndd = clsNHOMNGUOIDUNG.GetAll();
             var sql = (from row in _tbldsndd.AsEnumerable()
                        select new
                        {
                            NHOMNGUOIDUNG_ID = row.Field<int>("NHOMNGUOIDUNG_ID"),
                            MANHOMND = row.Field<string>("NHOMNGUOIDUNG_CODE"),
                            TENNHOMND = row.Field<string>("TENNHOMNGUOIDUNG")
                        }).AsQueryable();
             return Json(sql.ToList(), JsonRequestBehavior.AllowGet);
         }

         public JsonResult Get_DS_Quyen()
         {
             int NHOMNGUOIDUNG_ID = int.Parse(Request["NHOMNGUOIDUNG_ID"].ToString());
             DataTable _tbldsquyen = clsNHOMNGUOIDUNG.GetMenuBy_NhomNguoiDung(NHOMNGUOIDUNG_ID);
             var sql = (from row in _tbldsquyen.AsEnumerable()
                        select new
                        {
                            QUYEN_ID = row.Field<int>("QUYEN_ID"),
                            TENQUYEN = row.Field<string>("TENQUYEN"),
                            COQUYEN = row.Field<int>("COQUYEN")
                        }).AsQueryable();
             return Json(sql.ToList(), JsonRequestBehavior.AllowGet);
         }
         #endregion

        #region -- Cấu hình Danh mục
         ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region "Định Nghĩa Danh Mục"
         [HttpGet]
         public ActionResult DinhNghiaDanhMucDungChung()
         {
             ViewBag.CurrentAction = "DinhNghiaDanhMucDungChung";
             return View();
         }
        #endregion
         ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
         #region "Hệ Thống Danh Mục"
         [HttpGet]
         public ActionResult HeThongDanhMucDungChung()
         {
             ViewBag.CurrentAction = "HeThongDanhMucDungChung";
             return View();
         }
         #endregion
         ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region "Nhân viên"
        [HttpGet]
        public ActionResult DanhMucNhanVien()
        {
            ViewBag.CurrentAction = "DanhMucNhanVien";
            return View();
        }

        [HttpPost]
        public ActionResult DanhMucNhanVien(FormCollection f)
        {
            bool IsSuccess = false;
            string LOAI = Request["LOAI"];
            DataAccess m_Dal = new DataAccess();
            clsDM_NHANVIEN clsNHANVIEN = new clsDM_NHANVIEN(m_Dal);
            if (LOAI == "INSERT")
            {
                string MANHANVIEN = Request["MANHANVIEN"];
                string HO_NHANVIEN = Request["HO_NHANVIEN"];
                string TEN_NHANVIEN = Request["TEN_NHANVIEN"];
                int PHONGBAN_ID = int.Parse(Request["PHONGBAN_ID"]);
                int CHUCVU_ID = int.Parse(Request["CHUCVU_ID"]);
                int NHOMNGUOIDUNG_ID = int.Parse(Request["NHOMNGUOIDUNG_ID"]);
                bool GIOITINH = bool.Parse(Request["GIOITINH"]);
                string USERNAME = Request["USERNAME"];
                string PW = clsEncrypt.MD5(Request["PW"], "sale", true);
                string NGAYSINH_TMP = Request["NGAYSINH"];
                DateTime NGAYSINH = clsCommon.ChangeDate(NGAYSINH_TMP);

                m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                clsNHANVIEN.MANHANVIEN = MANHANVIEN;
                clsNHANVIEN.HO_NHANVIEN = HO_NHANVIEN;
                clsNHANVIEN.TEN_NHANVIEN = TEN_NHANVIEN;
                clsNHANVIEN.PHONGBAN_ID = PHONGBAN_ID;
                clsNHANVIEN.CHUCVU_ID = CHUCVU_ID;
                clsNHANVIEN.NHOMNGUOIDUNG_ID = NHOMNGUOIDUNG_ID;
                clsNHANVIEN.GIOITINH = GIOITINH;
                clsNHANVIEN.NGAYSINH = NGAYSINH;
                clsNHANVIEN.USERNAME = USERNAME;
                clsNHANVIEN.PW = PW;
                clsNHANVIEN.CREATED_BY = int.Parse(Session["NHANVIEN_ID"].ToString());
                clsNHANVIEN.LAST_UPDATED_BY = int.Parse(Session["NHANVIEN_ID"].ToString());
                clsNHANVIEN.TRANGTHAI_LAMVIEC = 1;
                IsSuccess = clsNHANVIEN.Add();
                if (IsSuccess)
                {
                    m_Dal.CommitTrans(true);
                    return Content("...");
                }
                else
                {
                    m_Dal.AbortTrans();
                    return Content("Tạo Nhân viên thất bại!");
                }
            }
            else if (LOAI == "UPDATE")
            {
                m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                clsNHANVIEN.NHANVIEN_ID = int.Parse(Request["NHANVIEN_ID"]);
                clsNHANVIEN.NHOMNGUOIDUNG_ID = int.Parse(Request["NHOMNGUOIDUNG_ID"]);
                clsNHANVIEN.CHUCVU_ID = int.Parse(Request["CHUCVU_ID"]);
                clsNHANVIEN.PHONGBAN_ID = int.Parse(Request["PHONGBAN_ID"]);
                clsNHANVIEN.MANHANVIEN = Request["MANHANVIEN"];
                clsNHANVIEN.HO_NHANVIEN = Request["HO_NHANVIEN"];
                clsNHANVIEN.EMAIL_NHANVIEN = Request["EMAIL_NHANVIEN"];
                clsNHANVIEN.GIOITINH = bool.Parse(Request["GIOITINH"]);
                clsNHANVIEN.DIACHI_TAMTRU = Request["DIACHI_TAMTRU"];
                clsNHANVIEN.USERNAME = Request["USERNAME"];
                clsNHANVIEN.PW = clsEncrypt.MD5(Request["PW"], "sale", true);
                clsNHANVIEN.LAST_UPDATED_BY = int.Parse(Session["NHANVIEN_ID"].ToString());
                clsNHANVIEN.CMND_SO = Request["CMND_SO"];
                clsNHANVIEN.CMND_NOICAP = Request["CMND_NOICAP"];
                clsNHANVIEN.DANTOC = int.Parse(Request["DANTOC"]);
                clsNHANVIEN.TONGIAO = int.Parse(Request["TONGIAO"]);
                clsNHANVIEN.DIENTHOAI_NHA = string.IsNullOrEmpty(Request["DIENTHOAI_NHA"]) ? 0 : int.Parse(Request["DIENTHOAI_NHA"]);
                clsNHANVIEN.DIENTHOAI_DIDONG = string.IsNullOrEmpty(Request["DIENTHOAI_DIDONG"]) ? 0 : int.Parse(Request["DIENTHOAI_DIDONG"]);
                clsNHANVIEN.DIACHI_THUONGTRU = Request["DIACHI_THUONGTRU"];
                clsNHANVIEN.TRANGTHAI_LAMVIEC = int.Parse(Request["TRANGTHAI_LAMVIEC"]);
                clsNHANVIEN.TRINHDO_VANHOA = Request["TRINHDO_VANHOA"];
                clsNHANVIEN.NOISINH = Request["NOISINH"];
                clsNHANVIEN.QUEQUAN = Request["QUEQUAN"];
                clsNHANVIEN.MASOTHUE = Request["MASOTHUE"];
                clsNHANVIEN.NGAYVAOLAM = clsCommon.ChangeDate(Request["NGAYVAOLAM"]);
                clsNHANVIEN.NGAYSINH = clsCommon.ChangeDate(Request["NGAYSINH"]);
                clsNHANVIEN.TEN_NHANVIEN= Request["TEN_NHANVIEN"];
                IsSuccess = clsNHANVIEN.Update();
                if (IsSuccess)
                {
                    m_Dal.CommitTrans(true);
                    return Content("...");
                }
                else
                {
                    m_Dal.AbortTrans();
                    return Content("Cập nhật Nhân viên thất bại!");
                }
            }
            else
            {
                int NHANVIEN_ID = int.Parse(Request["NHANVIEN_ID"]);
                m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                IsSuccess = clsNHANVIEN.Delete(NHANVIEN_ID);
                if (IsSuccess)
                {
                    m_Dal.CommitTrans(true);
                    return Content("...");
                }
                else
                {
                    m_Dal.AbortTrans();
                    return Content("Xóa Nhân viên thất bại!");
                }
            }
        }

        public JsonResult Get_DS_NhanVien()
        {
            DataTable _tbldspb = clsNHANVIEN.GetAll();
            var sql = (from row in _tbldspb.AsEnumerable()
                       select new
                       {
                           NHANVIEN_ID = row.Field<int>("NHANVIEN_ID"),
                           NHOMNGUOIDUNG_ID = row.Field<int>("NHOMNGUOIDUNG_ID"),
                           CHUCVU_ID = row.Field<int>("CHUCVU_ID"),
                           PHONGBAN_ID = row.Field<int>("PHONGBAN_ID"),
                           MANHANVIEN = row.Field<string>("MANHANVIEN"),
                           HO_NHANVIEN = row.Field<string>("HO_NHANVIEN"),
                           EMAIL_NHANVIEN = row.Field<string>("EMAIL_NHANVIEN"),
                           GIOITINH = row.Field<bool>("GIOITINH"),
                           DIACHI_TAMTRU = row.Field<string>("DIACHI_TAMTRU"),
                           USERNAME = row.Field<string>("USERNAME"),
                           PW = clsDecrypt.MD5(row.Field<string>("PW"), "sale", true),
                           ISLOGIN = row.Field<bool>("ISLOGIN"),
                           LOGIN_TIME = (row.Field<DateTime?>("LOGIN_TIME")).HasValue ? row.Field<DateTime>("LOGIN_TIME").ToString("dd/MM/yyyy HH:mm:ss") : "",
                           LAST_LOGOUT_TIME = (row.Field<DateTime?>("LAST_LOGOUT_TIME")).HasValue ? row.Field<DateTime>("LAST_LOGOUT_TIME").ToString("dd/MM/yyyy HH:mm:ss") : "",
                           CREATION_DATE = (row.Field<DateTime?>("CREATION_DATE")).HasValue ? row.Field<DateTime>("CREATION_DATE").ToString("dd/MM/yyyy") : "",
                           CREATED_BY = row.Field<int?>("CREATED_BY"),
                           LAST_UPDATE_DATE = (row.Field<DateTime?>("LAST_UPDATE_DATE")).HasValue ? row.Field<DateTime>("LAST_UPDATE_DATE").ToString("dd/MM/yyyy") : "",
                           LAST_UPDATED_BY = row.Field<int?>("LAST_UPDATED_BY"),
                           CMND_SO = row.Field<string>("CMND_SO"),
                           CMND_NOICAP = row.Field<string>("CMND_NOICAP"),
                           DANTOC = row.Field<int?>("DANTOC"),
                           TONGIAO = row.Field<int?>("TONGIAO"),
                           DIENTHOAI_NHA = row.Field<int?>("DIENTHOAI_NHA"),
                           DIENTHOAI_DIDONG = row.Field<int?>("DIENTHOAI_DIDONG"),
                           DIACHI_THUONGTRU = row.Field<string>("DIACHI_THUONGTRU"),
                           TRANGTHAI_LAMVIEC = row.Field<int?>("TRANGTHAI_LAMVIEC"),
                           TRINHDO_VANHOA = row.Field<string>("TRINHDO_VANHOA"),
                           NOISINH = row.Field<string>("NOISINH"),
                           QUEQUAN = row.Field<string>("QUEQUAN"),
                           MASOTHUE = row.Field<string>("MASOTHUE"),
                           NGAYVAOLAM = (row.Field<DateTime?>("NGAYVAOLAM")).HasValue ? row.Field<DateTime>("NGAYVAOLAM").ToString("dd/MM/yyyy") : "",
                           NGAYSINH = (row.Field<DateTime?>("NGAYSINH")).HasValue ? row.Field<DateTime>("NGAYSINH").ToString("dd/MM/yyyy") : "",
                           TEN_NHANVIEN = row.Field<string>("TEN_NHANVIEN"),
                           HOTEN = row.Field<string>("HOTEN"),
                           GT = row.Field<string>("GT"),
                           TENPHONGBAN = row.Field<string>("TENPHONGBAN"),
                           TENCHUCVU = row.Field<string>("TENCHUCVU"),
                           TENNHOMND = row.Field<string>("TENNHOMND")
                       }).AsQueryable();


            return Json(sql.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Get_NhanVien_By_Id()
        {
            int NHANVIEN_ID = int.Parse(Request["NHANVIEN_ID"]);
            var _tbldspb = clsNHANVIEN.GetByKey(NHANVIEN_ID);
            //var sql = (from row in _tbldspb.AsEnumerable()
            //           select new
            //           {
            //               NHANVIEN_ID = row.Field<int>("NHANVIEN_ID"),
            //               NHOMNGUOIDUNG_ID = row.Field<int>("NHOMNGUOIDUNG_ID"),
            //               CHUCVU_ID = row.Field<int>("CHUCVU_ID"),
            //               PHONGBAN_ID = row.Field<int>("PHONGBAN_ID"),
            //               MANHANVIEN = row.Field<string>("MANHANVIEN"),
            //               HO_NHANVIEN = row.Field<string>("HO_NHANVIEN"),
            //               EMAIL_NHANVIEN = row.Field<string>("EMAIL_NHANVIEN"),
            //               GIOITINH = row.Field<bool>("GIOITINH"),
            //               DIACHI_TAMTRU = row.Field<string>("DIACHI_TAMTRU"),
            //               USERNAME = row.Field<string>("USERNAME"),
            //               PW = row.Field<string>("PW"),
            //               ISLOGIN = row.Field<bool>("ISLOGIN"),
            //               LOGIN_TIME = (row.Field<DateTime?>("LOGIN_TIME")).HasValue ? row.Field<DateTime>("LOGIN_TIME").ToString("dd/MM/yyyy HH:mm:ss") : "",
            //               LAST_LOGOUT_TIME = (row.Field<DateTime?>("LAST_LOGOUT_TIME")).HasValue ? row.Field<DateTime>("LAST_LOGOUT_TIME").ToString("dd/MM/yyyy HH:mm:ss") : "",
            //               CREATION_DATE = (row.Field<DateTime?>("CREATION_DATE")).HasValue ? row.Field<DateTime>("CREATION_DATE").ToString("dd/MM/yyyy") : "",
            //               CREATED_BY = row.Field<int?>("CREATED_BY"),
            //               LAST_UPDATE_DATE = (row.Field<DateTime?>("LAST_UPDATE_DATE")).HasValue ? row.Field<DateTime>("LAST_UPDATE_DATE").ToString("dd/MM/yyyy") : "",
            //               LAST_UPDATED_BY = row.Field<int?>("LAST_UPDATED_BY"),
            //               CMND_SO = row.Field<string>("CMND_SO"),
            //               CMND_NOICAP = row.Field<string>("CMND_NOICAP"),
            //               DANTOC = row.Field<int?>("DANTOC"),
            //               TONGIAO = row.Field<int?>("TONGIAO"),
            //               DIENTHOAI_NHA = row.Field<int?>("DIENTHOAI_NHA"),
            //               DIENTHOAI_DIDONG = row.Field<int?>("DIENTHOAI_DIDONG"),
            //               DIACHI_THUONGTRU = row.Field<string>("DIACHI_THUONGTRU"),
            //               TRANGTHAI_LAMVIEC = row.Field<int?>("TRANGTHAI_LAMVIEC"),
            //               TRINHDO_VANHOA = row.Field<string>("TRINHDO_VANHOA"),
            //               NOISINH = row.Field<string>("NOISINH"),
            //               QUEQUAN = row.Field<string>("QUEQUAN"),
            //               MASOTHUE = row.Field<string>("MASOTHUE"),
            //               NGAYVAOLAM = (row.Field<DateTime?>("NGAYVAOLAM")).HasValue ? row.Field<DateTime>("NGAYVAOLAM").ToString("dd/MM/yyyy") : "",
            //               NGAYSINH = (row.Field<DateTime?>("NGAYSINH")).HasValue ? row.Field<DateTime>("NGAYSINH").ToString("dd/MM/yyyy") : "",
            //               TEN_NHANVIEN = row.Field<string>("TEN_NHANVIEN"),
            //               HOTEN = row.Field<string>("HOTEN"),
            //               GT = row.Field<string>("GT"),
            //               TENPHONGBAN = row.Field<string>("TENPHONGBAN"),
            //               TENCHUCVU = row.Field<string>("TENCHUCVU"),
            //               TENNHOMND = row.Field<string>("TENNHOMND")
            //           }).AsQueryable();

            var json = new JavaScriptSerializer().Serialize(_tbldspb);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
        #endregion
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region "Chức vụ"
        [HttpGet]
        public ActionResult DanhMucChucVu()
        {
            ViewBag.CurrentAction = "DanhMucChucVu";
            return View();
        }

        [HttpPost]
        public ActionResult DanhMucChucVu(FormCollection f)
        {
            bool IsSuccess = false;
            string LOAI = Request["LOAI"];
            DataAccess m_Dal = new DataAccess();
            clsDM_CHUCVU clsCHUCVU = new clsDM_CHUCVU(m_Dal);
            if (LOAI == "INSERT")
            {
                string MACHUCVU = Request["MACHUCVU"];
                string TENCHUCVU = Request["TENCHUCVU"];
                m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                clsCHUCVU.MACHUCVU = MACHUCVU;
                clsCHUCVU.TENCHUCVU = TENCHUCVU;
                IsSuccess = clsCHUCVU.Add();
                if (IsSuccess)
                {
                    m_Dal.CommitTrans(true);
                    return Content("...");
                }
                else
                {
                    m_Dal.AbortTrans();
                    return Content("Tạo Chức vụ thất bại!");
                }
            }
            else if (LOAI == "UPDATE")
            {
                int CHUCVU_ID = int.Parse(Request["CHUCVU_ID"]);
                string MACHUCVU = Request["MACHUCVU"];
                string TENCHUCVU = Request["TENCHUCVU"];
                m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                clsCHUCVU.CHUCVU_ID = CHUCVU_ID;
                clsCHUCVU.MACHUCVU = MACHUCVU;
                clsCHUCVU.TENCHUCVU = TENCHUCVU;
                IsSuccess = clsCHUCVU.Update();
                if (IsSuccess)
                {
                    m_Dal.CommitTrans(true);
                    return Content("...");
                }
                else
                {
                    m_Dal.AbortTrans();
                    return Content("Cập nhật Chức vụ thất bại!");
                }
            }
            else
            {
                int CHUCVU_ID = int.Parse(Request["CHUCVU_ID"]);
                m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                IsSuccess = clsCHUCVU.Delete(CHUCVU_ID);
                if (IsSuccess)
                {
                    m_Dal.CommitTrans(true);
                    return Content("...");
                }
                else
                {
                    m_Dal.AbortTrans();
                    return Content("Xóa Chức vụ thất bại!");
                }
            }
        }

        public JsonResult Get_DS_ChucVu()
        {
            DataTable _tbldscv = clsCHUCVU.GetAll();
            var sql = (from row in _tbldscv.AsEnumerable()
                       select new
                       {
                           CHUCVU_ID = row.Field<int>("CHUCVU_ID"),
                           MACHUCVU = row.Field<string>("MACHUCVU"),
                           TENCHUCVU = row.Field<string>("TENCHUCVU")
                       }).AsQueryable();
            return Json(sql.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Get_ChucVu_By_Code()
        {
            int CHUCVU_ID = int.Parse(Request["CHUCVU_ID"].ToString());
            DataTable _tbldscv = clsCHUCVU.Get_ChucVu_By_Code(CHUCVU_ID);
            var sql = (from row in _tbldscv.AsEnumerable()
                       select new
                       {
                           CHUCVU_ID = row.Field<int>("CHUCVU_ID"),
                           MACHUCVU = row.Field<string>("MACHUCVU"),
                           TENCHUCVU = row.Field<string>("TENCHUCVU")
                       }).AsQueryable();
            return Json(sql.ToList(), JsonRequestBehavior.AllowGet);
        }
        #endregion
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region "Phòng ban"
        [HttpGet]
        public ActionResult DanhMucPhongBan()
        {
            ViewBag.CurrentAction = "DanhMucPhongBan";
            return View();
        }

        [HttpPost]
        public ActionResult DanhMucPhongBan(FormCollection f)
        {
            bool IsSuccess = false;
            string LOAI = Request["LOAI"];
            DataAccess m_Dal = new DataAccess();
            clsDM_PHONGBAN clsPHONGBAN = new clsDM_PHONGBAN(m_Dal);
            if (LOAI == "INSERT")
            {
                string MAPHONGBAN = Request["MAPHONGBAN"];
                string TENPHONGBAN = Request["TENPHONGBAN"];
                m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                clsPHONGBAN.MAPHONGBAN = MAPHONGBAN;
                clsPHONGBAN.TENPHONGBAN = TENPHONGBAN;
                IsSuccess = clsPHONGBAN.Add();
                if (IsSuccess)
                {
                    m_Dal.CommitTrans(true);
                    return Content("...");
                }
                else
                {
                    m_Dal.AbortTrans();
                    return Content("Tạo Phòng ban thất bại!");
                }
            }
            else if (LOAI == "UPDATE")
            {
                int PHONGBAN_ID = int.Parse(Request["PHONGBAN_ID"]);
                string MAPHONGBAN = Request["MAPHONGBAN"];
                string TENPHONGBAN = Request["TENPHONGBAN"];
                m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                clsPHONGBAN.PHONGBAN_ID = PHONGBAN_ID;
                clsPHONGBAN.MAPHONGBAN = MAPHONGBAN;
                clsPHONGBAN.TENPHONGBAN = TENPHONGBAN;
                IsSuccess = clsPHONGBAN.Update();
                if (IsSuccess)
                {
                    m_Dal.CommitTrans(true);
                    return Content("...");
                }
                else
                {
                    m_Dal.AbortTrans();
                    return Content("Cập nhật Phòng ban thất bại!");
                }
            }
            else
            {
                int PHONGBAN_ID = int.Parse(Request["PHONGBAN_ID"]);
                m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                IsSuccess = clsPHONGBAN.Delete(PHONGBAN_ID);
                if (IsSuccess)
                {
                    m_Dal.CommitTrans(true);
                    return Content("...");
                }
                else
                {
                    m_Dal.AbortTrans();
                    return Content("Xóa Phòng ban thất bại!");
                }
            }
        }

        public JsonResult Get_DS_PhongBan()
        {
            DataTable _tbldspb = clsPHONGBAN.GetAll();
            var sql = (from row in _tbldspb.AsEnumerable()
                       select new
                       {
                           PHONGBAN_ID = row.Field<int>("PHONGBAN_ID"),
                           MAPHONGBAN = row.Field<string>("MAPHONGBAN"),
                           TENPHONGBAN = row.Field<string>("TENPHONGBAN")
                       }).AsQueryable();


            return Json(sql.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Get_PhongBan_By_Code()
        {
            int PHONGBAN_ID = int.Parse(Request["PHONGBAN_ID"].ToString());
            DataTable _tbldspb = clsPHONGBAN.Get_PhongBan_By_Code(PHONGBAN_ID);
            var sql = (from row in _tbldspb.AsEnumerable()
                       select new
                       {
                           PHONGBAN_ID = row.Field<int>("PHONGBAN_ID"),
                           MAPHONGBAN = row.Field<string>("MAPHONGBAN"),
                           TENPHONGBAN = row.Field<string>("TENPHONGBAN")
                       }).AsQueryable();
            return Json(sql.ToList(), JsonRequestBehavior.AllowGet);
        }
        #endregion
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
            DataTable _tbldsdistrict = objQuanHuyen.GetQuanHuyenByTinhThanh(PROVINCE_ID);
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
            DataTable _tbldsward = objPhuongXa.GetPhuongXaByQuanHuyen(DISTRICT_ID);
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

         
        #endregion

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
        public sealed class NoCacheAttribute : ActionFilterAttribute
        {
            public override void OnResultExecuting(ResultExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Cache.SetExpires(DateTime.UtcNow.AddDays(-1));
                filterContext.HttpContext.Response.Cache.SetValidUntilExpires(false);
                filterContext.HttpContext.Response.Cache.SetRevalidation(HttpCacheRevalidation.AllCaches);
                filterContext.HttpContext.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                filterContext.HttpContext.Response.Cache.SetNoStore();

                base.OnResultExecuting(filterContext);
            }
        }
    }
}