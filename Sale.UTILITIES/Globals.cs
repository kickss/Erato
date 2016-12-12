using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading;

using Sale.DAL;

namespace Sale.UTILITIES
{
    public sealed class SaleGlobals : IDisposable
    {
        #region "Variable"
        //--------------------------------------------------------------------------
        private static int m_LoginSession_Id;
        //-----------------------------------------------------------------
        private static int m_NHANVIEN_ID;
        private static string m_NHANVIEN_CODE;
        private static string m_NHANVIEN_NAME;
        //-----------------------------------------------------------------
        private static string m_USER_NAME;
        private static string m_USER_CODE;
        private static int m_USER_ID;
        //-----------------------------------------------------------------
        private static int m_NHOMNGUOIDUNG_ID;
        private static string m_NHOMNGUOIDUNG_CODE;
        //-----------------------------------------------------------------
        private static int m_IS_ADMIN;
        //--------------------------------------------------------------
        private static string m_DOMAIN_CODE;
        private static int m_DOMAIN_ID;
        //--------------------------------------------------------------
        private static DateTime m_WorkingDate;

        private static DateTime m_CurrentServerDateTime;
        #endregion

        #region "Properties"
        
        public static int IS_ADMIN
        {
            get
            {
                return m_IS_ADMIN;
            }
            set 
            {
                if (value != m_IS_ADMIN)
                {
                    m_IS_ADMIN = value;
                }
            }
           
        }
        public static int DOMAIN_ID
        {
            get
            {
                return m_DOMAIN_ID;
            }
            set 
            {
                if (value != m_DOMAIN_ID)
                {
                    m_DOMAIN_ID = value;
                }
            }
        }
        public static string DOMAIN_CODE
        {
           
            get
            {
                return m_DOMAIN_CODE;
            }
            set 
            {
                if (value != m_DOMAIN_CODE)
                {
                    m_DOMAIN_CODE = value;
                }
            }
        }
        public static int USER_ID
        {
             
            get
            {
                return m_USER_ID;
            }
            set
            {
                if (value != m_USER_ID)
                {
                    m_USER_ID = value;
                }
            }
        }
        public static string USER_CODE
        {
           
            get
            {
                return m_USER_CODE;
            }
            set
            {
                if (value != m_USER_CODE)
                {
                    m_USER_CODE = value;
                }
            }
        }
        public static string USER_NAME
        {
             
            get
            {
                return m_USER_NAME;
            }
            set
            {
                if (value != m_USER_NAME)
                {
                    m_USER_NAME = value;
                }
            }
        }
        public static int NHANVIEN_ID
        {
            
            get
            {
                return m_NHANVIEN_ID;
            }
            set
            {
                if (value != m_NHANVIEN_ID)
                {
                    m_NHANVIEN_ID = value;
                }
            }
        }
        public static string NHANVIEN_CODE
        {
            
            get
            {
                return m_NHANVIEN_CODE;
            }
            set
            {
                if (value != m_NHANVIEN_CODE)
                {
                    m_NHANVIEN_CODE = value;
                }
            }
        }
        public static string NHANVIEN_NAME
        {
            get
            {
                return m_NHANVIEN_NAME;
            }
            set
            {
                if (value != m_NHANVIEN_NAME)
                {
                    m_NHANVIEN_NAME = value;
                }
            }
        }
        public static int NHOMNGUOIDUNG_ID
        {

            get
            {
                return m_NHOMNGUOIDUNG_ID;
            }
            set
            {
                if (value != m_NHOMNGUOIDUNG_ID)
                {
                    m_NHOMNGUOIDUNG_ID = value;
                }
            }
        }
        public static string NHOMNGUOIDUNG_CODE
        {

            get
            {
                return m_NHOMNGUOIDUNG_CODE;
            }
            set
            {
                if (value != m_NHOMNGUOIDUNG_CODE)
                {
                    m_NHOMNGUOIDUNG_CODE = value;
                }
            }
        }
        //----------------------------------
        public static DateTime WorkingDate
        {
             
            get
            {
                return m_WorkingDate;
            }
            set
            {
                if (value != m_WorkingDate)
                {
                    m_WorkingDate = value;
                }
            }
        }
        public static int LoginSession_Id
        {
             
            get
            {
                return m_LoginSession_Id;
            }
            set
            {
                if (value != m_LoginSession_Id)
                {
                    m_LoginSession_Id = value;
                }
            }
        }
        public static DateTime CurrentServerDateTime
        {
            get
            {
                System.DateTime result;
                try
                {
                    DataAccess dataAccess = new DataAccess();
                    result = System.Convert.ToDateTime(dataAccess.ExecuteScalar("SELECT GETDATE()"));
                }
                catch
                {
                    result = System.DateTime.Now;
                }
                finally
                {

                }
                return result;
            }
            set { m_CurrentServerDateTime = value; }
        }

        #endregion
        public static void Reset()
        {
            NHANVIEN_ID = int.MinValue;
            NHANVIEN_CODE = string.Empty;
            NHANVIEN_NAME = string.Empty; 
            //-------------------------
            IS_ADMIN = int.MinValue;
            //-------------------------
            USER_ID = int.MinValue;
            USER_CODE = string.Empty; 
            USER_NAME = string.Empty; 
            //-----------------
            NHOMNGUOIDUNG_ID = int.MinValue;
            NHOMNGUOIDUNG_CODE = string.Empty; 
            //-----------------
            LoginSession_Id = int.MinValue;
            //-------------------------
            DOMAIN_ID = int.MinValue;
            DOMAIN_CODE = string.Empty; 
            //Domain_Name;
            //User_TokenKey;
            //IsAdmin = false;
        }
        public void Dispose()
        {
            try
            {
               
                GC.SuppressFinalize(this);      
            }
            catch
            {
            }
        }

        
    }
}
