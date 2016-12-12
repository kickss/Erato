



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsAPP_HOADON_CHITIET
    {
        private const string SP_APP_HOADON_CHITIET = "sp_APP_HOADON_CHITIET";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarHOADON_CHITIET_ID;
        private Int32 mvarHOADON_ID;
        private Int32 mvarLOPHOC_ID;
        private string mvarLOPHOC_CODE;
        private Decimal mvarDONGIA;
        private Int32 mvarSOLUONG;
        private Decimal mvarTHANHTIEN;
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

        public Int32 HOADON_CHITIET_ID
        {
            get { return mvarHOADON_CHITIET_ID; }
            set { mvarHOADON_CHITIET_ID = value; }
        }

        public Int32 HOADON_ID
        {
            get { return mvarHOADON_ID; }
            set { mvarHOADON_ID = value; }
        }

        public Int32 LOPHOC_ID
        {
            get { return mvarLOPHOC_ID; }
            set { mvarLOPHOC_ID = value; }
        }

        public string LOPHOC_CODE
        {
            get { return mvarLOPHOC_CODE; }
            set { mvarLOPHOC_CODE = value; }
        }

        public Decimal DONGIA
        {
            get { return mvarDONGIA; }
            set { mvarDONGIA = value; }
        }

        public Int32 SOLUONG
        {
            get { return mvarSOLUONG; }
            set { mvarSOLUONG = value; }
        }

        public Decimal THANHTIEN
        {
            get { return mvarTHANHTIEN; }
            set { mvarTHANHTIEN = value; }
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
        public clsAPP_HOADON_CHITIET()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsAPP_HOADON_CHITIET(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsAPP_HOADON_CHITIET(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsAPP_HOADON_CHITIET(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = SP_APP_HOADON_CHITIET;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@HOADON_CHITIET_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarHOADON_CHITIET_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@HOADON_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarHOADON_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOPHOC_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOPHOC_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOPHOC_CODE", DbType.String, clsCommon.GetValueDBNull(mvarLOPHOC_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DONGIA", DbType.Decimal, clsCommon.GetValueDBNull(mvarDONGIA), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@SOLUONG", DbType.Int32, clsCommon.GetValueDBNull(mvarSOLUONG), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@THANHTIEN", DbType.Decimal, clsCommon.GetValueDBNull(mvarTHANHTIEN), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));

                DAL.ExecNonQuery();

                mvarHOADON_CHITIET_ID = Int32.Parse(clsCommon.GetValue(DAL.Parameters.Items("@HOADON_CHITIET_ID").Value, mvarHOADON_CHITIET_ID.GetType().FullName).ToString());

                return (mvarHOADON_CHITIET_ID > 0);
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
                DAL.CommandText = SP_APP_HOADON_CHITIET;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@HOADON_CHITIET_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarHOADON_CHITIET_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@HOADON_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarHOADON_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOPHOC_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOPHOC_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOPHOC_CODE", DbType.String, clsCommon.GetValueDBNull(mvarLOPHOC_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DONGIA", DbType.Decimal, clsCommon.GetValueDBNull(mvarDONGIA), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@SOLUONG", DbType.Int32, clsCommon.GetValueDBNull(mvarSOLUONG), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@THANHTIEN", DbType.Decimal, clsCommon.GetValueDBNull(mvarTHANHTIEN), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int HOADON_CHITIET_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_APP_HOADON_CHITIET;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@HOADON_CHITIET_ID", DbType.Int32, clsCommon.GetValueDBNull(HOADON_CHITIET_ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_APP_HOADON_CHITIET;
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

        public bool GetByKey(int HOADON_CHITIET_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_APP_HOADON_CHITIET;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@HOADON_CHITIET_ID", DbType.Int32, clsCommon.GetValueDBNull(HOADON_CHITIET_ID), ParameterDirection.InputOutput, 4));
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

            mvarHOADON_CHITIET_ID = Int32.MinValue;
            mvarHOADON_ID = Int32.MinValue;
            mvarLOPHOC_ID = Int32.MinValue;
            mvarLOPHOC_CODE = string.Empty;
            mvarDONGIA = Decimal.MinValue;
            mvarSOLUONG = Int32.MinValue;
            mvarTHANHTIEN = Decimal.MinValue;
            mvarCREATION_DATE = DateTime.MinValue;
            mvarCREATED_BY = Int32.MinValue;
            mvarLAST_UPDATE_DATE = DateTime.MinValue;
            mvarLAST_UPDATED_BY = Int32.MinValue;
        }

        public void FillData(DataRow row)
        {

            mvarHOADON_CHITIET_ID = Int32.Parse(clsCommon.GetValue(row["HOADON_CHITIET_ID"], mvarHOADON_CHITIET_ID.GetType().FullName).ToString());
            mvarHOADON_ID = Int32.Parse(clsCommon.GetValue(row["HOADON_ID"], mvarHOADON_ID.GetType().FullName).ToString());
            mvarLOPHOC_ID = Int32.Parse(clsCommon.GetValue(row["LOPHOC_ID"], mvarLOPHOC_ID.GetType().FullName).ToString());
            mvarLOPHOC_CODE = clsCommon.GetValue(row["LOPHOC_CODE"], mvarLOPHOC_CODE.GetType().FullName).ToString();
            mvarDONGIA = Decimal.Parse(clsCommon.GetValue(row["DONGIA"], mvarDONGIA.GetType().FullName).ToString());
            mvarSOLUONG = Int32.Parse(clsCommon.GetValue(row["SOLUONG"], mvarSOLUONG.GetType().FullName).ToString());
            mvarTHANHTIEN = Decimal.Parse(clsCommon.GetValue(row["THANHTIEN"], mvarTHANHTIEN.GetType().FullName).ToString());
            mvarCREATION_DATE = DateTime.Parse(clsCommon.GetValue(row["CREATION_DATE"], mvarCREATION_DATE.GetType().FullName).ToString());
            mvarCREATED_BY = Int32.Parse(clsCommon.GetValue(row["CREATED_BY"], mvarCREATED_BY.GetType().FullName).ToString());
            mvarLAST_UPDATE_DATE = DateTime.Parse(clsCommon.GetValue(row["LAST_UPDATE_DATE"], mvarLAST_UPDATE_DATE.GetType().FullName).ToString());
            mvarLAST_UPDATED_BY = Int32.Parse(clsCommon.GetValue(row["LAST_UPDATED_BY"], mvarLAST_UPDATED_BY.GetType().FullName).ToString());
        }

        #endregion


        #region "Other Methods"
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        #endregion

    }
}


