using System;
using System.Data;
using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsSYS_NHOMNGUOIDUNG
    {
        private const string SP_SYS_NHOMNGUOIDUNG = "sp_SYS_NHOMNGUOIDUNG";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarNHOMNGUOIDUNG_ID;
        private string mvarNHOMNGUOIDUNG_CODE;
        private string mvarTENNHOMNGUOIDUNG;
        private Boolean mvarHOATDONG;
        private DateTime mvarCREATION_DATE;
        private Int32 mvarCREATED_BY;
        private DateTime mvarLAST_UPDATE_DATE;
        private Int32 mvarLAST_UPDATED_BY;
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

        public Int32 NHOMNGUOIDUNG_ID
        {
            get { return mvarNHOMNGUOIDUNG_ID; }
            set { mvarNHOMNGUOIDUNG_ID = value; }
        }

        public string NHOMNGUOIDUNG_CODE
        {
            get { return mvarNHOMNGUOIDUNG_CODE; }
            set { mvarNHOMNGUOIDUNG_CODE = value; }
        }

        public string TENNHOMNGUOIDUNG
        {
            get { return mvarTENNHOMNGUOIDUNG; }
            set { mvarTENNHOMNGUOIDUNG = value; }
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

        #endregion

        #region "Constructors"
        public clsSYS_NHOMNGUOIDUNG()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsSYS_NHOMNGUOIDUNG(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsSYS_NHOMNGUOIDUNG(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsSYS_NHOMNGUOIDUNG(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = SP_SYS_NHOMNGUOIDUNG;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarNHOMNGUOIDUNG_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarNHOMNGUOIDUNG_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TENNHOMNGUOIDUNG", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarTENNHOMNGUOIDUNG), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@HOATDONG", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarHOATDONG), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));

                DAL.ExecNonQuery();

                mvarNHOMNGUOIDUNG_ID = Int32.Parse(UTILITIES.clsCommon.GetValue(DAL.Parameters.Items("@NHOMNGUOIDUNG_ID").Value, mvarNHOMNGUOIDUNG_ID.GetType().FullName).ToString());

                return (mvarNHOMNGUOIDUNG_ID > 0);
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
                DAL.CommandText = SP_SYS_NHOMNGUOIDUNG;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarNHOMNGUOIDUNG_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarNHOMNGUOIDUNG_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TENNHOMNGUOIDUNG", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarTENNHOMNGUOIDUNG), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@HOATDONG", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarHOATDONG), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int NHOMNGUOIDUNG_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_NHOMNGUOIDUNG;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(NHOMNGUOIDUNG_ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_SYS_NHOMNGUOIDUNG;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetAll", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                ds = DAL.ExecDataSet();
                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool GetByKey(int NHOMNGUOIDUNG_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_NHOMNGUOIDUNG;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(NHOMNGUOIDUNG_ID), ParameterDirection.InputOutput, 4));
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

            mvarNHOMNGUOIDUNG_ID = Int32.MinValue;
            mvarNHOMNGUOIDUNG_CODE = string.Empty;
            mvarTENNHOMNGUOIDUNG = string.Empty;
            mvarHOATDONG = false;
            mvarCREATION_DATE = DateTime.MinValue;
            mvarCREATED_BY = Int32.MinValue;
            mvarLAST_UPDATE_DATE = DateTime.MinValue;
            mvarLAST_UPDATED_BY = Int32.MinValue;
        }

        public void FillData(DataRow row)
        {

            mvarNHOMNGUOIDUNG_ID = Int32.Parse(UTILITIES.clsCommon.GetValue(row["NHOMNGUOIDUNG_ID"], mvarNHOMNGUOIDUNG_ID.GetType().FullName).ToString());
            mvarNHOMNGUOIDUNG_CODE = UTILITIES.clsCommon.GetValue(row["NHOMNGUOIDUNG_CODE"], mvarNHOMNGUOIDUNG_CODE.GetType().FullName).ToString();
            mvarTENNHOMNGUOIDUNG = UTILITIES.clsCommon.GetValue(row["TENNHOMNGUOIDUNG"], mvarTENNHOMNGUOIDUNG.GetType().FullName).ToString();
            mvarHOATDONG = Boolean.Parse(UTILITIES.clsCommon.GetValue(row["HOATDONG"], mvarHOATDONG.GetType().FullName).ToString());
            mvarCREATION_DATE = DateTime.Parse(UTILITIES.clsCommon.GetValue(row["CREATION_DATE"], mvarCREATION_DATE.GetType().FullName).ToString());
            mvarCREATED_BY = Int32.Parse(UTILITIES.clsCommon.GetValue(row["CREATED_BY"], mvarCREATED_BY.GetType().FullName).ToString());
            mvarLAST_UPDATE_DATE = DateTime.Parse(UTILITIES.clsCommon.GetValue(row["LAST_UPDATE_DATE"], mvarLAST_UPDATE_DATE.GetType().FullName).ToString());
            mvarLAST_UPDATED_BY = Int32.Parse(UTILITIES.clsCommon.GetValue(row["LAST_UPDATED_BY"], mvarLAST_UPDATED_BY.GetType().FullName).ToString());
        }

        #endregion

        

        #region "Other Methods"	
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        
        //Get danh sach menu theo nhom nguoi dung ==> da su dung
        public DataTable GetMenuBy_NhomNguoiDung(int intNHOMNGUOIDUNG_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_NHOMNGUOIDUNG;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetMenuBy_NhomNguoiDung", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, clsCommon.GetValueDBNull(intNHOMNGUOIDUNG_ID), ParameterDirection.InputOutput, 4));
                ds = DAL.ExecDataSet();
                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetMenuBy_MaNhomNguoiDung(int strNHOMNGUOIDUNG_CODE)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_NHOMNGUOIDUNG;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetMenuBy_MaNhomNguoiDung", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(strNHOMNGUOIDUNG_CODE), ParameterDirection.Input, 1000));
                ds = DAL.ExecDataSet();
                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}


