



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsDM_GIANGVIEN
    {
        private const string SP_DM_GIANGVIEN = "sp_DM_GIANGVIEN";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarGIANGVIEN_ID;
        private string mvarMAGIANGVIEN;
        private string mvarTENGIANGVIEN;
        private Int32 mvarUSER_ID;
        private string mvarUSER_NAME;
        private string mvarSO_CMND;
        private string mvarDIENTHOAI;
        private string mvarDIDONG;
        private Int32 mvarCHUCVU_ID;
        private string mvarCHUCVU_CODE;
        private Boolean mvarHOATDONG;
        private DateTime mvarCREATION_DATE;
        private Int32 mvarCREATED_BY;
        private DateTime mvarLAST_UPDATE_DATE;
        private Int32 mvarLAST_UPDATED_BY;
        private Decimal mvarTYLE_HUONG;
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

        public Int32 GIANGVIEN_ID
        {
            get { return mvarGIANGVIEN_ID; }
            set { mvarGIANGVIEN_ID = value; }
        }

        public string MAGIANGVIEN
        {
            get { return mvarMAGIANGVIEN; }
            set { mvarMAGIANGVIEN = value; }
        }

        public string TENGIANGVIEN
        {
            get { return mvarTENGIANGVIEN; }
            set { mvarTENGIANGVIEN = value; }
        }

        public Int32 USER_ID
        {
            get { return mvarUSER_ID; }
            set { mvarUSER_ID = value; }
        }

        public string USER_NAME
        {
            get { return mvarUSER_NAME; }
            set { mvarUSER_NAME = value; }
        }

        public string SO_CMND
        {
            get { return mvarSO_CMND; }
            set { mvarSO_CMND = value; }
        }

        public string DIENTHOAI
        {
            get { return mvarDIENTHOAI; }
            set { mvarDIENTHOAI = value; }
        }

        public string DIDONG
        {
            get { return mvarDIDONG; }
            set { mvarDIDONG = value; }
        }

        public Int32 CHUCVU_ID
        {
            get { return mvarCHUCVU_ID; }
            set { mvarCHUCVU_ID = value; }
        }

        public string CHUCVU_CODE
        {
            get { return mvarCHUCVU_CODE; }
            set { mvarCHUCVU_CODE = value; }
        }

        public Boolean HOATDONG
        {
            get { return mvarHOATDONG; }
            set { mvarHOATDONG = value; }
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

        public Decimal TYLE_HUONG
        {
            get { return mvarTYLE_HUONG; }
            set { mvarTYLE_HUONG = value; }
        }

        #endregion


        #region "Constructors"
        public clsDM_GIANGVIEN()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsDM_GIANGVIEN(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsDM_GIANGVIEN(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsDM_GIANGVIEN(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = SP_DM_GIANGVIEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarGIANGVIEN_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@MAGIANGVIEN", DbType.String, clsCommon.GetValueDBNull(mvarMAGIANGVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TENGIANGVIEN", DbType.String, clsCommon.GetValueDBNull(mvarTENGIANGVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@USER_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSER_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USER_NAME", DbType.String, clsCommon.GetValueDBNull(mvarUSER_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@SO_CMND", DbType.String, clsCommon.GetValueDBNull(mvarSO_CMND), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DIENTHOAI", DbType.String, clsCommon.GetValueDBNull(mvarDIENTHOAI), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DIDONG", DbType.String, clsCommon.GetValueDBNull(mvarDIDONG), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@CHUCVU_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarCHUCVU_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@CHUCVU_CODE", DbType.String, clsCommon.GetValueDBNull(mvarCHUCVU_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@HOATDONG", DbType.Boolean, clsCommon.GetValueDBNull(mvarHOATDONG), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@TYLE_HUONG", DbType.Decimal, clsCommon.GetValueDBNull(mvarTYLE_HUONG), ParameterDirection.Input, 19));

                DAL.ExecNonQuery();

                mvarGIANGVIEN_ID = Int32.Parse(clsCommon.GetValue(DAL.Parameters.Items("@GIANGVIEN_ID").Value, mvarGIANGVIEN_ID.GetType().FullName).ToString());

                return (mvarGIANGVIEN_ID > 0);
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
                DAL.CommandText = SP_DM_GIANGVIEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarGIANGVIEN_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@MAGIANGVIEN", DbType.String, clsCommon.GetValueDBNull(mvarMAGIANGVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TENGIANGVIEN", DbType.String, clsCommon.GetValueDBNull(mvarTENGIANGVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@USER_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSER_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USER_NAME", DbType.String, clsCommon.GetValueDBNull(mvarUSER_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@SO_CMND", DbType.String, clsCommon.GetValueDBNull(mvarSO_CMND), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DIENTHOAI", DbType.String, clsCommon.GetValueDBNull(mvarDIENTHOAI), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DIDONG", DbType.String, clsCommon.GetValueDBNull(mvarDIDONG), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@CHUCVU_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarCHUCVU_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@CHUCVU_CODE", DbType.String, clsCommon.GetValueDBNull(mvarCHUCVU_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@HOATDONG", DbType.Boolean, clsCommon.GetValueDBNull(mvarHOATDONG), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@TYLE_HUONG", DbType.Decimal, clsCommon.GetValueDBNull(mvarTYLE_HUONG), ParameterDirection.Input, 19));

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int GIANGVIEN_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_GIANGVIEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(GIANGVIEN_ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_DM_GIANGVIEN;
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

        public bool GetByKey(int GIANGVIEN_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_GIANGVIEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(GIANGVIEN_ID), ParameterDirection.InputOutput, 4));
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

            mvarGIANGVIEN_ID = Int32.MinValue;
            mvarMAGIANGVIEN = string.Empty;
            mvarTENGIANGVIEN = string.Empty;
            mvarUSER_ID = Int32.MinValue;
            mvarUSER_NAME = string.Empty;
            mvarSO_CMND = string.Empty;
            mvarDIENTHOAI = string.Empty;
            mvarDIDONG = string.Empty;
            mvarCHUCVU_ID = Int32.MinValue;
            mvarCHUCVU_CODE = string.Empty;
            mvarHOATDONG = false;
            mvarCREATION_DATE = DateTime.MinValue;
            mvarCREATED_BY = Int32.MinValue;
            mvarLAST_UPDATE_DATE = DateTime.MinValue;
            mvarLAST_UPDATED_BY = Int32.MinValue;
            mvarTYLE_HUONG = Decimal.MinValue;
        }

        public void FillData(DataRow row)
        {

            mvarGIANGVIEN_ID = Int32.Parse(clsCommon.GetValue(row["GIANGVIEN_ID"], mvarGIANGVIEN_ID.GetType().FullName).ToString());
            mvarMAGIANGVIEN = clsCommon.GetValue(row["MAGIANGVIEN"], mvarMAGIANGVIEN.GetType().FullName).ToString();
            mvarTENGIANGVIEN = clsCommon.GetValue(row["TENGIANGVIEN"], mvarTENGIANGVIEN.GetType().FullName).ToString();
            mvarUSER_ID = Int32.Parse(clsCommon.GetValue(row["USER_ID"], mvarUSER_ID.GetType().FullName).ToString());
            mvarUSER_NAME = clsCommon.GetValue(row["USER_NAME"], mvarUSER_NAME.GetType().FullName).ToString();
            mvarSO_CMND = clsCommon.GetValue(row["SO_CMND"], mvarSO_CMND.GetType().FullName).ToString();
            mvarDIENTHOAI = clsCommon.GetValue(row["DIENTHOAI"], mvarDIENTHOAI.GetType().FullName).ToString();
            mvarDIDONG = clsCommon.GetValue(row["DIDONG"], mvarDIDONG.GetType().FullName).ToString();
            mvarCHUCVU_ID = Int32.Parse(clsCommon.GetValue(row["CHUCVU_ID"], mvarCHUCVU_ID.GetType().FullName).ToString());
            mvarCHUCVU_CODE = clsCommon.GetValue(row["CHUCVU_CODE"], mvarCHUCVU_CODE.GetType().FullName).ToString();
            mvarHOATDONG = Boolean.Parse(clsCommon.GetValue(row["HOATDONG"], mvarHOATDONG.GetType().FullName).ToString());
            mvarCREATION_DATE = DateTime.Parse(clsCommon.GetValue(row["CREATION_DATE"], mvarCREATION_DATE.GetType().FullName).ToString());
            mvarCREATED_BY = Int32.Parse(clsCommon.GetValue(row["CREATED_BY"], mvarCREATED_BY.GetType().FullName).ToString());
            mvarLAST_UPDATE_DATE = DateTime.Parse(clsCommon.GetValue(row["LAST_UPDATE_DATE"], mvarLAST_UPDATE_DATE.GetType().FullName).ToString());
            mvarLAST_UPDATED_BY = Int32.Parse(clsCommon.GetValue(row["LAST_UPDATED_BY"], mvarLAST_UPDATED_BY.GetType().FullName).ToString());
            mvarTYLE_HUONG = Decimal.Parse(clsCommon.GetValue(row["TYLE_HUONG"], mvarTYLE_HUONG.GetType().FullName).ToString());
        }

        #endregion


        #region "Other Methods"
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        #endregion

    }
}


