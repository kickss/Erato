



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsAPP_HOCVIEN_DANGKY_LOPHOC
    {
        private const string SP_APP_HOCVIEN_DANGKY_LOPHOC = "sp_APP_HOCVIEN_DANGKY_LOPHOC";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarID;
        private DateTime mvarNGAY_DANGKY;
        private Int32 mvarHOCVIEN_ID;
        private string mvarHOCVIEN_CODE;
        private string mvarTENHOCVIEN;
        private Int32 mvarLOPHOC_ID;
        private string mvarLOPHOC_CODE;
        private Int32 mvarTHOILUONG;
        private DateTime mvarSTART_DATE;
        private DateTime mvarEND_DATE;
        private Boolean mvarHOC_THU;
        private Int32 mvarHOADON_ID;
        private string mvarHOADON_CODE;
        private DateTime mvarCREATION_DATE;
        private Int32 mvarCREATED_BY;
        private DateTime mvarLAST_UPDATE_DATE;
        private Int32 mvarLAST_UPDATED_BY;
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

        public Int32 ID
        {
            get { return mvarID; }
            set { mvarID = value; }
        }

        public DateTime NGAY_DANGKY
        {
            get { return mvarNGAY_DANGKY; }
            set { mvarNGAY_DANGKY = value; }
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

        public string TENHOCVIEN
        {
            get { return mvarTENHOCVIEN; }
            set { mvarTENHOCVIEN = value; }
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

        public Int32 THOILUONG
        {
            get { return mvarTHOILUONG; }
            set { mvarTHOILUONG = value; }
        }

        public DateTime START_DATE
        {
            get { return mvarSTART_DATE; }
            set { mvarSTART_DATE = value; }
        }

        public DateTime END_DATE
        {
            get { return mvarEND_DATE; }
            set { mvarEND_DATE = value; }
        }

        public Boolean HOC_THU
        {
            get { return mvarHOC_THU; }
            set { mvarHOC_THU = value; }
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

        public Int32 LOGIN_SESSION_ID
        {
            get { return mvarLOGIN_SESSION_ID; }
            set { mvarLOGIN_SESSION_ID = value; }
        }

        #endregion


        #region "Constructors"
        public clsAPP_HOCVIEN_DANGKY_LOPHOC()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsAPP_HOCVIEN_DANGKY_LOPHOC(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsAPP_HOCVIEN_DANGKY_LOPHOC(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsAPP_HOCVIEN_DANGKY_LOPHOC(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = SP_APP_HOCVIEN_DANGKY_LOPHOC;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@ID", DbType.Int32, clsCommon.GetValueDBNull(mvarID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@NGAY_DANGKY", DbType.DateTime, clsCommon.GetValueDBNull(mvarNGAY_DANGKY), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@HOCVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarHOCVIEN_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@HOCVIEN_CODE", DbType.String, clsCommon.GetValueDBNull(mvarHOCVIEN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TENHOCVIEN", DbType.String, clsCommon.GetValueDBNull(mvarTENHOCVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@LOPHOC_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOPHOC_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOPHOC_CODE", DbType.String, clsCommon.GetValueDBNull(mvarLOPHOC_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@THOILUONG", DbType.Int32, clsCommon.GetValueDBNull(mvarTHOILUONG), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@START_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarSTART_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@END_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarEND_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@HOC_THU", DbType.Boolean, clsCommon.GetValueDBNull(mvarHOC_THU), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@HOADON_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarHOADON_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@HOADON_CODE", DbType.String, clsCommon.GetValueDBNull(mvarHOADON_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_SESSION_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOGIN_SESSION_ID), ParameterDirection.Input, 4));

                DAL.ExecNonQuery();

                mvarID = Int32.Parse(clsCommon.GetValue(DAL.Parameters.Items("@ID").Value, mvarID.GetType().FullName).ToString());

                return (mvarID > 0);
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
                DAL.CommandText = SP_APP_HOCVIEN_DANGKY_LOPHOC;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@ID", DbType.Int32, clsCommon.GetValueDBNull(mvarID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@NGAY_DANGKY", DbType.DateTime, clsCommon.GetValueDBNull(mvarNGAY_DANGKY), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@HOCVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarHOCVIEN_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@HOCVIEN_CODE", DbType.String, clsCommon.GetValueDBNull(mvarHOCVIEN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TENHOCVIEN", DbType.String, clsCommon.GetValueDBNull(mvarTENHOCVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@LOPHOC_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOPHOC_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOPHOC_CODE", DbType.String, clsCommon.GetValueDBNull(mvarLOPHOC_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@THOILUONG", DbType.Int32, clsCommon.GetValueDBNull(mvarTHOILUONG), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@START_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarSTART_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@END_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarEND_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@HOC_THU", DbType.Boolean, clsCommon.GetValueDBNull(mvarHOC_THU), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@HOADON_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarHOADON_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@HOADON_CODE", DbType.String, clsCommon.GetValueDBNull(mvarHOADON_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_SESSION_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOGIN_SESSION_ID), ParameterDirection.Input, 4));

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_APP_HOCVIEN_DANGKY_LOPHOC;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@ID", DbType.Int32, clsCommon.GetValueDBNull(ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_APP_HOCVIEN_DANGKY_LOPHOC;
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

        public bool GetByKey(int ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_APP_HOCVIEN_DANGKY_LOPHOC;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@ID", DbType.Int32, clsCommon.GetValueDBNull(ID), ParameterDirection.InputOutput, 4));
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

            mvarID = Int32.MinValue;
            mvarNGAY_DANGKY = DateTime.MinValue;
            mvarHOCVIEN_ID = Int32.MinValue;
            mvarHOCVIEN_CODE = string.Empty;
            mvarTENHOCVIEN = string.Empty;
            mvarLOPHOC_ID = Int32.MinValue;
            mvarLOPHOC_CODE = string.Empty;
            mvarTHOILUONG = Int32.MinValue;
            mvarSTART_DATE = DateTime.MinValue;
            mvarEND_DATE = DateTime.MinValue;
            mvarHOC_THU = false;
            mvarHOADON_ID = Int32.MinValue;
            mvarHOADON_CODE = string.Empty;
            mvarCREATION_DATE = DateTime.MinValue;
            mvarCREATED_BY = Int32.MinValue;
            mvarLAST_UPDATE_DATE = DateTime.MinValue;
            mvarLAST_UPDATED_BY = Int32.MinValue;
            mvarLOGIN_SESSION_ID = Int32.MinValue;
        }

        public void FillData(DataRow row)
        {

            mvarID = Int32.Parse(clsCommon.GetValue(row["ID"], mvarID.GetType().FullName).ToString());
            mvarNGAY_DANGKY = DateTime.Parse(clsCommon.GetValue(row["NGAY_DANGKY"], mvarNGAY_DANGKY.GetType().FullName).ToString());
            mvarHOCVIEN_ID = Int32.Parse(clsCommon.GetValue(row["HOCVIEN_ID"], mvarHOCVIEN_ID.GetType().FullName).ToString());
            mvarHOCVIEN_CODE = clsCommon.GetValue(row["HOCVIEN_CODE"], mvarHOCVIEN_CODE.GetType().FullName).ToString();
            mvarTENHOCVIEN = clsCommon.GetValue(row["TENHOCVIEN"], mvarTENHOCVIEN.GetType().FullName).ToString();
            mvarLOPHOC_ID = Int32.Parse(clsCommon.GetValue(row["LOPHOC_ID"], mvarLOPHOC_ID.GetType().FullName).ToString());
            mvarLOPHOC_CODE = clsCommon.GetValue(row["LOPHOC_CODE"], mvarLOPHOC_CODE.GetType().FullName).ToString();
            mvarTHOILUONG = Int32.Parse(clsCommon.GetValue(row["THOILUONG"], mvarTHOILUONG.GetType().FullName).ToString());
            mvarSTART_DATE = DateTime.Parse(clsCommon.GetValue(row["START_DATE"], mvarSTART_DATE.GetType().FullName).ToString());
            mvarEND_DATE = DateTime.Parse(clsCommon.GetValue(row["END_DATE"], mvarEND_DATE.GetType().FullName).ToString());
            mvarHOC_THU = Boolean.Parse(clsCommon.GetValue(row["HOC_THU"], mvarHOC_THU.GetType().FullName).ToString());
            mvarHOADON_ID = Int32.Parse(clsCommon.GetValue(row["HOADON_ID"], mvarHOADON_ID.GetType().FullName).ToString());
            mvarHOADON_CODE = clsCommon.GetValue(row["HOADON_CODE"], mvarHOADON_CODE.GetType().FullName).ToString();
            mvarCREATION_DATE = DateTime.Parse(clsCommon.GetValue(row["CREATION_DATE"], mvarCREATION_DATE.GetType().FullName).ToString());
            mvarCREATED_BY = Int32.Parse(clsCommon.GetValue(row["CREATED_BY"], mvarCREATED_BY.GetType().FullName).ToString());
            mvarLAST_UPDATE_DATE = DateTime.Parse(clsCommon.GetValue(row["LAST_UPDATE_DATE"], mvarLAST_UPDATE_DATE.GetType().FullName).ToString());
            mvarLAST_UPDATED_BY = Int32.Parse(clsCommon.GetValue(row["LAST_UPDATED_BY"], mvarLAST_UPDATED_BY.GetType().FullName).ToString());
            mvarLOGIN_SESSION_ID = Int32.Parse(clsCommon.GetValue(row["LOGIN_SESSION_ID"], mvarLOGIN_SESSION_ID.GetType().FullName).ToString());
        }

        #endregion


        #region "Other Methods"
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        #endregion

    }
}


