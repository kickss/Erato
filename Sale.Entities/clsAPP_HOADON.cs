



using System;
using System.Data;


using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsAPP_HOADON
    {
        private const string SP_APP_HOADON = "sp_APP_HOADON";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarHOADON_ID;
        private string mvarHOADON_CODE;
        private Int32 mvarHOCVIEN_ID;
        private string mvarHOCVIEN_CODE;
        private DateTime mvarNGAYHOADON;
        private Boolean mvarDATHANHTOAN;
        private string mvarNHANVIEN_CODE;
        private Int32 mvarNHANVIEN_ID;
        private DateTime mvarCREATION_DATE;
        private Int32 mvarCREATED_BY;
        private DateTime mvarLAST_UPDATE_DATE;
        private Int32 mvarLAST_UPDATED_BY;
        private Boolean mvarALLOW_EDIT;
        private Int32 mvarPRINT_NUM;
        private Int32 mvarLOGIN_SESSION_ID;
        #endregion

        #region "Properties"
        public string LANGUAGEID
        {
            get { return mvarLANGUAGEID; }
            set { mvarLANGUAGEID = value; }
        }

        public Int32 USERID
        {
            get { return mvarUSERID; }
            set { mvarUSERID = value; }
        }

        public string FREEPARA
        {
            get { return mvarFREEPARA; }
            set { mvarFREEPARA = value; }
        }

        public Int32 HOADON_ID
        {
            get { return mvarHOADON_ID; }
            set { mvarHOADON_ID = value; }
        }

        public string HOADON_CODE
        {
            get { return mvarHOADON_CODE; }
            set { mvarHOADON_CODE = value; }
        }

        public Int32 HOCVIEN_ID
        {
            get { return mvarHOCVIEN_ID; }
            set { mvarHOCVIEN_ID = value; }
        }

        public string HOCVIEN_CODE
        {
            get { return mvarHOCVIEN_CODE; }
            set { mvarHOCVIEN_CODE = value; }
        }

        public DateTime NGAYHOADON
        {
            get { return mvarNGAYHOADON; }
            set { mvarNGAYHOADON = value; }
        }

        public Boolean DATHANHTOAN
        {
            get { return mvarDATHANHTOAN; }
            set { mvarDATHANHTOAN = value; }
        }

        public string NHANVIEN_CODE
        {
            get { return mvarNHANVIEN_CODE; }
            set { mvarNHANVIEN_CODE = value; }
        }

        public Int32 NHANVIEN_ID
        {
            get { return mvarNHANVIEN_ID; }
            set { mvarNHANVIEN_ID = value; }
        }

        public DateTime CREATION_DATE
        {
            get { return mvarCREATION_DATE; }
            set { mvarCREATION_DATE = value; }
        }

        public Int32 CREATED_BY
        {
            get { return mvarCREATED_BY; }
            set { mvarCREATED_BY = value; }
        }

        public DateTime LAST_UPDATE_DATE
        {
            get { return mvarLAST_UPDATE_DATE; }
            set { mvarLAST_UPDATE_DATE = value; }
        }

        public Int32 LAST_UPDATED_BY
        {
            get { return mvarLAST_UPDATED_BY; }
            set { mvarLAST_UPDATED_BY = value; }
        }

        public Boolean ALLOW_EDIT
        {
            get { return mvarALLOW_EDIT; }
            set { mvarALLOW_EDIT = value; }
        }

        public Int32 PRINT_NUM
        {
            get { return mvarPRINT_NUM; }
            set { mvarPRINT_NUM = value; }
        }

        public Int32 LOGIN_SESSION_ID
        {
            get { return mvarLOGIN_SESSION_ID; }
            set { mvarLOGIN_SESSION_ID = value; }
        }

        #endregion


        #region "Constructors"
        public clsAPP_HOADON()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsAPP_HOADON(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsAPP_HOADON(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsAPP_HOADON(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = mdal;
        }

        #endregion
        #region "Methods"

        public bool Add()
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_APP_HOADON;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@HOADON_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarHOADON_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@HOADON_CODE", DbType.String, clsCommon.GetValueDBNull(mvarHOADON_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@HOCVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarHOCVIEN_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@HOCVIEN_CODE", DbType.String, clsCommon.GetValueDBNull(mvarHOCVIEN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@NGAYHOADON", DbType.DateTime, clsCommon.GetValueDBNull(mvarNGAYHOADON), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@DATHANHTOAN", DbType.Boolean, clsCommon.GetValueDBNull(mvarDATHANHTOAN), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@NHANVIEN_CODE", DbType.String, clsCommon.GetValueDBNull(mvarNHANVIEN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@NHANVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarNHANVIEN_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@ALLOW_EDIT", DbType.Boolean, clsCommon.GetValueDBNull(mvarALLOW_EDIT), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@PRINT_NUM", DbType.Int32, clsCommon.GetValueDBNull(mvarPRINT_NUM), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_SESSION_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOGIN_SESSION_ID), ParameterDirection.Input, 4));

                DAL.ExecNonQuery();

                mvarHOADON_ID = Int32.Parse(clsCommon.GetValue(DAL.Parameters.Items("@HOADON_ID").Value, mvarHOADON_ID.GetType().FullName).ToString());

                return (mvarHOADON_ID > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update()
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_APP_HOADON;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@HOADON_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarHOADON_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@HOADON_CODE", DbType.String, clsCommon.GetValueDBNull(mvarHOADON_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@HOCVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarHOCVIEN_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@HOCVIEN_CODE", DbType.String, clsCommon.GetValueDBNull(mvarHOCVIEN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@NGAYHOADON", DbType.DateTime, clsCommon.GetValueDBNull(mvarNGAYHOADON), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@DATHANHTOAN", DbType.Boolean, clsCommon.GetValueDBNull(mvarDATHANHTOAN), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@NHANVIEN_CODE", DbType.String, clsCommon.GetValueDBNull(mvarNHANVIEN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@NHANVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarNHANVIEN_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@ALLOW_EDIT", DbType.Boolean, clsCommon.GetValueDBNull(mvarALLOW_EDIT), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@PRINT_NUM", DbType.Int32, clsCommon.GetValueDBNull(mvarPRINT_NUM), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_SESSION_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOGIN_SESSION_ID), ParameterDirection.Input, 4));

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int HOADON_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_APP_HOADON;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@HOADON_ID", DbType.Int32, clsCommon.GetValueDBNull(HOADON_ID), ParameterDirection.InputOutput, 4));
                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable GetAll()
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_APP_HOADON;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetAll", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                ds = DAL.ExecDataSet();
                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool GetByKey(int HOADON_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_APP_HOADON;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@HOADON_ID", DbType.Int32, clsCommon.GetValueDBNull(HOADON_ID), ParameterDirection.InputOutput, 4));
                ds = DAL.ExecDataSet();

                Reset();

                if (ds == null || ds.Tables.Count == 0)
                {
                    return false;
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillData(ds.Tables[0].Rows[0]);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }

        public void Reset()
        {
            mvarLANGUAGEID = string.Empty;
            mvarUSERID = Int32.MinValue;
            mvarFREEPARA = string.Empty;

            mvarHOADON_ID = Int32.MinValue;
            mvarHOADON_CODE = string.Empty;
            mvarHOCVIEN_ID = Int32.MinValue;
            mvarHOCVIEN_CODE = string.Empty;
            mvarNGAYHOADON = DateTime.MinValue;
            mvarDATHANHTOAN = false;
            mvarNHANVIEN_CODE = string.Empty;
            mvarNHANVIEN_ID = Int32.MinValue;
            mvarCREATION_DATE = DateTime.MinValue;
            mvarCREATED_BY = Int32.MinValue;
            mvarLAST_UPDATE_DATE = DateTime.MinValue;
            mvarLAST_UPDATED_BY = Int32.MinValue;
            mvarALLOW_EDIT = false;
            mvarPRINT_NUM = Int32.MinValue;
            mvarLOGIN_SESSION_ID = Int32.MinValue;
        }

        public void FillData(DataRow row)
        {

            mvarHOADON_ID = Int32.Parse(clsCommon.GetValue(row["HOADON_ID"], mvarHOADON_ID.GetType().FullName).ToString());
            mvarHOADON_CODE = clsCommon.GetValue(row["HOADON_CODE"], mvarHOADON_CODE.GetType().FullName).ToString();
            mvarHOCVIEN_ID = Int32.Parse(clsCommon.GetValue(row["HOCVIEN_ID"], mvarHOCVIEN_ID.GetType().FullName).ToString());
            mvarHOCVIEN_CODE = clsCommon.GetValue(row["HOCVIEN_CODE"], mvarHOCVIEN_CODE.GetType().FullName).ToString();
            mvarNGAYHOADON = DateTime.Parse(clsCommon.GetValue(row["NGAYHOADON"], mvarNGAYHOADON.GetType().FullName).ToString());
            mvarDATHANHTOAN = Boolean.Parse(clsCommon.GetValue(row["DATHANHTOAN"], mvarDATHANHTOAN.GetType().FullName).ToString());
            mvarNHANVIEN_CODE = clsCommon.GetValue(row["NHANVIEN_CODE"], mvarNHANVIEN_CODE.GetType().FullName).ToString();
            mvarNHANVIEN_ID = Int32.Parse(clsCommon.GetValue(row["NHANVIEN_ID"], mvarNHANVIEN_ID.GetType().FullName).ToString());
            mvarCREATION_DATE = DateTime.Parse(clsCommon.GetValue(row["CREATION_DATE"], mvarCREATION_DATE.GetType().FullName).ToString());
            mvarCREATED_BY = Int32.Parse(clsCommon.GetValue(row["CREATED_BY"], mvarCREATED_BY.GetType().FullName).ToString());
            mvarLAST_UPDATE_DATE = DateTime.Parse(clsCommon.GetValue(row["LAST_UPDATE_DATE"], mvarLAST_UPDATE_DATE.GetType().FullName).ToString());
            mvarLAST_UPDATED_BY = Int32.Parse(clsCommon.GetValue(row["LAST_UPDATED_BY"], mvarLAST_UPDATED_BY.GetType().FullName).ToString());
            mvarALLOW_EDIT = Boolean.Parse(clsCommon.GetValue(row["ALLOW_EDIT"], mvarALLOW_EDIT.GetType().FullName).ToString());
            mvarPRINT_NUM = Int32.Parse(clsCommon.GetValue(row["PRINT_NUM"], mvarPRINT_NUM.GetType().FullName).ToString());
            mvarLOGIN_SESSION_ID = Int32.Parse(clsCommon.GetValue(row["LOGIN_SESSION_ID"], mvarLOGIN_SESSION_ID.GetType().FullName).ToString());
        }

        #endregion


        #region "Other Methods"
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        #endregion

    }
}


