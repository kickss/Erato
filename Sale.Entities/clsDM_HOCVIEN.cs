



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsDM_HOCVIEN
    {
        private const string SP_DM_HOCVIEN = "sp_DM_HOCVIEN";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarHOCVIEN_ID;
        private string mvarMAHOCVIEN;
        private string mvarTENHOCVIEN;
        private Int32 mvarUSER_ID;
        private string mvarUSER_NAME;
        private DateTime mvarNGAYSINH;
        private string mvarDIEN_THOAI;
        private string mvarDIEN_THOAI_LH;
        private string mvarDIACHI;
        private string mvarSO_NHA;
        private string mvarTINHTHANH_CODE;
        private string mvarQUANHUYEN_CODE;
        private string mvarPHUONGXA_CODE;
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

        public Int32 HOCVIEN_ID
        {
            get { return mvarHOCVIEN_ID; }
            set { mvarHOCVIEN_ID = value; }
        }

        public string MAHOCVIEN
        {
            get { return mvarMAHOCVIEN; }
            set { mvarMAHOCVIEN = value; }
        }

        public string TENHOCVIEN
        {
            get { return mvarTENHOCVIEN; }
            set { mvarTENHOCVIEN = value; }
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

        public DateTime NGAYSINH
        {
            get { return mvarNGAYSINH; }
            set { mvarNGAYSINH = value; }
        }

        public string DIEN_THOAI
        {
            get { return mvarDIEN_THOAI; }
            set { mvarDIEN_THOAI = value; }
        }

        public string DIEN_THOAI_LH
        {
            get { return mvarDIEN_THOAI_LH; }
            set { mvarDIEN_THOAI_LH = value; }
        }

        public string DIACHI
        {
            get { return mvarDIACHI; }
            set { mvarDIACHI = value; }
        }

        public string SO_NHA
        {
            get { return mvarSO_NHA; }
            set { mvarSO_NHA = value; }
        }

        public string TINHTHANH_CODE
        {
            get { return mvarTINHTHANH_CODE; }
            set { mvarTINHTHANH_CODE = value; }
        }

        public string QUANHUYEN_CODE
        {
            get { return mvarQUANHUYEN_CODE; }
            set { mvarQUANHUYEN_CODE = value; }
        }

        public string PHUONGXA_CODE
        {
            get { return mvarPHUONGXA_CODE; }
            set { mvarPHUONGXA_CODE = value; }
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
        public clsDM_HOCVIEN()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsDM_HOCVIEN(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsDM_HOCVIEN(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsDM_HOCVIEN(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = SP_DM_HOCVIEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@HOCVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarHOCVIEN_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@MAHOCVIEN", DbType.String, clsCommon.GetValueDBNull(mvarMAHOCVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TENHOCVIEN", DbType.String, clsCommon.GetValueDBNull(mvarTENHOCVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@USER_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSER_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USER_NAME", DbType.String, clsCommon.GetValueDBNull(mvarUSER_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@NGAYSINH", DbType.DateTime, clsCommon.GetValueDBNull(mvarNGAYSINH), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@DIEN_THOAI", DbType.String, clsCommon.GetValueDBNull(mvarDIEN_THOAI), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DIEN_THOAI_LH", DbType.String, clsCommon.GetValueDBNull(mvarDIEN_THOAI_LH), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DIACHI", DbType.String, clsCommon.GetValueDBNull(mvarDIACHI), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@SO_NHA", DbType.String, clsCommon.GetValueDBNull(mvarSO_NHA), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TINHTHANH_CODE", DbType.String, clsCommon.GetValueDBNull(mvarTINHTHANH_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@QUANHUYEN_CODE", DbType.String, clsCommon.GetValueDBNull(mvarQUANHUYEN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@PHUONGXA_CODE", DbType.String, clsCommon.GetValueDBNull(mvarPHUONGXA_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@HOATDONG", DbType.Boolean, clsCommon.GetValueDBNull(mvarHOATDONG), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));

                DAL.ExecNonQuery();

                mvarHOCVIEN_ID = Int32.Parse(clsCommon.GetValue(DAL.Parameters.Items("@HOCVIEN_ID").Value, mvarHOCVIEN_ID.GetType().FullName).ToString());

                return (mvarHOCVIEN_ID > 0);
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
                DAL.CommandText = SP_DM_HOCVIEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@HOCVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarHOCVIEN_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@MAHOCVIEN", DbType.String, clsCommon.GetValueDBNull(mvarMAHOCVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TENHOCVIEN", DbType.String, clsCommon.GetValueDBNull(mvarTENHOCVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@USER_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSER_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USER_NAME", DbType.String, clsCommon.GetValueDBNull(mvarUSER_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@NGAYSINH", DbType.DateTime, clsCommon.GetValueDBNull(mvarNGAYSINH), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@DIEN_THOAI", DbType.String, clsCommon.GetValueDBNull(mvarDIEN_THOAI), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DIEN_THOAI_LH", DbType.String, clsCommon.GetValueDBNull(mvarDIEN_THOAI_LH), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DIACHI", DbType.String, clsCommon.GetValueDBNull(mvarDIACHI), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@SO_NHA", DbType.String, clsCommon.GetValueDBNull(mvarSO_NHA), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TINHTHANH_CODE", DbType.String, clsCommon.GetValueDBNull(mvarTINHTHANH_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@QUANHUYEN_CODE", DbType.String, clsCommon.GetValueDBNull(mvarQUANHUYEN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@PHUONGXA_CODE", DbType.String, clsCommon.GetValueDBNull(mvarPHUONGXA_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@HOATDONG", DbType.Boolean, clsCommon.GetValueDBNull(mvarHOATDONG), ParameterDirection.Input, 2));
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

        public bool Delete(int HOCVIEN_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_HOCVIEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@HOCVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(HOCVIEN_ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_DM_HOCVIEN;
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

        public bool GetByKey(int HOCVIEN_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_HOCVIEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@HOCVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(HOCVIEN_ID), ParameterDirection.InputOutput, 4));
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

            mvarHOCVIEN_ID = Int32.MinValue;
            mvarMAHOCVIEN = string.Empty;
            mvarTENHOCVIEN = string.Empty;
            mvarUSER_ID = Int32.MinValue;
            mvarUSER_NAME = string.Empty;
            mvarNGAYSINH = DateTime.MinValue;
            mvarDIEN_THOAI = string.Empty;
            mvarDIEN_THOAI_LH = string.Empty;
            mvarDIACHI = string.Empty;
            mvarSO_NHA = string.Empty;
            mvarTINHTHANH_CODE = string.Empty;
            mvarQUANHUYEN_CODE = string.Empty;
            mvarPHUONGXA_CODE = string.Empty;
            mvarHOATDONG = false;
            mvarCREATION_DATE = DateTime.MinValue;
            mvarCREATED_BY = Int32.MinValue;
            mvarLAST_UPDATE_DATE = DateTime.MinValue;
            mvarLAST_UPDATED_BY = Int32.MinValue;
        }

        public void FillData(DataRow row)
        {

            mvarHOCVIEN_ID = Int32.Parse(clsCommon.GetValue(row["HOCVIEN_ID"], mvarHOCVIEN_ID.GetType().FullName).ToString());
            mvarMAHOCVIEN = clsCommon.GetValue(row["MAHOCVIEN"], mvarMAHOCVIEN.GetType().FullName).ToString();
            mvarTENHOCVIEN = clsCommon.GetValue(row["TENHOCVIEN"], mvarTENHOCVIEN.GetType().FullName).ToString();
            mvarUSER_ID = Int32.Parse(clsCommon.GetValue(row["USER_ID"], mvarUSER_ID.GetType().FullName).ToString());
            mvarUSER_NAME = clsCommon.GetValue(row["USER_NAME"], mvarUSER_NAME.GetType().FullName).ToString();
            mvarNGAYSINH = DateTime.Parse(clsCommon.GetValue(row["NGAYSINH"], mvarNGAYSINH.GetType().FullName).ToString());
            mvarDIEN_THOAI = clsCommon.GetValue(row["DIEN_THOAI"], mvarDIEN_THOAI.GetType().FullName).ToString();
            mvarDIEN_THOAI_LH = clsCommon.GetValue(row["DIEN_THOAI_LH"], mvarDIEN_THOAI_LH.GetType().FullName).ToString();
            mvarDIACHI = clsCommon.GetValue(row["DIACHI"], mvarDIACHI.GetType().FullName).ToString();
            mvarSO_NHA = clsCommon.GetValue(row["SO_NHA"], mvarSO_NHA.GetType().FullName).ToString();
            mvarTINHTHANH_CODE = clsCommon.GetValue(row["TINHTHANH_CODE"], mvarTINHTHANH_CODE.GetType().FullName).ToString();
            mvarQUANHUYEN_CODE = clsCommon.GetValue(row["QUANHUYEN_CODE"], mvarQUANHUYEN_CODE.GetType().FullName).ToString();
            mvarPHUONGXA_CODE = clsCommon.GetValue(row["PHUONGXA_CODE"], mvarPHUONGXA_CODE.GetType().FullName).ToString();
            mvarHOATDONG = Boolean.Parse(clsCommon.GetValue(row["HOATDONG"], mvarHOATDONG.GetType().FullName).ToString());
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


