



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsAPP_DIEMDANH_LOPHOC
    {
        private const string SP_APP_DIEMDANH_LOPHOC = "sp_APP_DIEMDANH_LOPHOC";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarDIEMDANH_ID;
        private DateTime mvarNGAY_DIEMDANH;
        private Int32 mvarLOPHOC_ID;
        private string mvarLOPHOC_CODE;
        private Int32 mvarGIANGVIEN_ID;
        private string mvarGIANGVIEN_CODE;
        private Boolean mvarTINH_PHI;
        private Int32 mvarTYPE_ID;
        private string mvarTYPE_NOTE;
        private Boolean mvarALLOW_EDIT;
        private Int32 mvarEDIT_BY_GIAOVU;
        private string mvarGIAOVU_CODE;
        private DateTime mvarCREATION_DATE;
        private Int32 mvarCREATED_BY;
        private DateTime mvarLAST_UPDATE_DATE;
        private Int32 mvarLAST_UPDATED_BY;
        private Int32 mvarLOGIN_SESSION_ID;
        private string mvarLOGIN_SESSION;
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

        public Int32 DIEMDANH_ID
        {
            get { return mvarDIEMDANH_ID; }
            set { mvarDIEMDANH_ID = value; }
        }

        public DateTime NGAY_DIEMDANH
        {
            get { return mvarNGAY_DIEMDANH; }
            set { mvarNGAY_DIEMDANH = value; }
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

        public Int32 GIANGVIEN_ID
        {
            get { return mvarGIANGVIEN_ID; }
            set { mvarGIANGVIEN_ID = value; }
        }

        public string GIANGVIEN_CODE
        {
            get { return mvarGIANGVIEN_CODE; }
            set { mvarGIANGVIEN_CODE = value; }
        }

        public Boolean TINH_PHI
        {
            get { return mvarTINH_PHI; }
            set { mvarTINH_PHI = value; }
        }

        public Int32 TYPE_ID
        {
            get { return mvarTYPE_ID; }
            set { mvarTYPE_ID = value; }
        }

        public string TYPE_NOTE
        {
            get { return mvarTYPE_NOTE; }
            set { mvarTYPE_NOTE = value; }
        }

        public Boolean ALLOW_EDIT
        {
            get { return mvarALLOW_EDIT; }
            set { mvarALLOW_EDIT = value; }
        }

        public Int32 EDIT_BY_GIAOVU
        {
            get { return mvarEDIT_BY_GIAOVU; }
            set { mvarEDIT_BY_GIAOVU = value; }
        }

        public string GIAOVU_CODE
        {
            get { return mvarGIAOVU_CODE; }
            set { mvarGIAOVU_CODE = value; }
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

        public string LOGIN_SESSION
        {
            get { return mvarLOGIN_SESSION; }
            set { mvarLOGIN_SESSION = value; }
        }

        #endregion


        #region "Constructors"
        public clsAPP_DIEMDANH_LOPHOC()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsAPP_DIEMDANH_LOPHOC(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsAPP_DIEMDANH_LOPHOC(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsAPP_DIEMDANH_LOPHOC(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = SP_APP_DIEMDANH_LOPHOC;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@DIEMDANH_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarDIEMDANH_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@NGAY_DIEMDANH", DbType.DateTime, clsCommon.GetValueDBNull(mvarNGAY_DIEMDANH), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LOPHOC_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOPHOC_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOPHOC_CODE", DbType.String, clsCommon.GetValueDBNull(mvarLOPHOC_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarGIANGVIEN_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN_CODE", DbType.String, clsCommon.GetValueDBNull(mvarGIANGVIEN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TINH_PHI", DbType.Boolean, clsCommon.GetValueDBNull(mvarTINH_PHI), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@TYPE_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarTYPE_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@TYPE_NOTE", DbType.String, clsCommon.GetValueDBNull(mvarTYPE_NOTE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@ALLOW_EDIT", DbType.Boolean, clsCommon.GetValueDBNull(mvarALLOW_EDIT), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@EDIT_BY_GIAOVU", DbType.Int32, clsCommon.GetValueDBNull(mvarEDIT_BY_GIAOVU), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@GIAOVU_CODE", DbType.String, clsCommon.GetValueDBNull(mvarGIAOVU_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_SESSION_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOGIN_SESSION_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_SESSION", DbType.String, clsCommon.GetValueDBNull(mvarLOGIN_SESSION), ParameterDirection.Input, 1000));

                DAL.ExecNonQuery();

                mvarDIEMDANH_ID = Int32.Parse(clsCommon.GetValue(DAL.Parameters.Items("@DIEMDANH_ID").Value, mvarDIEMDANH_ID.GetType().FullName).ToString());

                return (mvarDIEMDANH_ID > 0);
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
                DAL.CommandText = SP_APP_DIEMDANH_LOPHOC;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@DIEMDANH_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarDIEMDANH_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@NGAY_DIEMDANH", DbType.DateTime, clsCommon.GetValueDBNull(mvarNGAY_DIEMDANH), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LOPHOC_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOPHOC_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOPHOC_CODE", DbType.String, clsCommon.GetValueDBNull(mvarLOPHOC_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarGIANGVIEN_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN_CODE", DbType.String, clsCommon.GetValueDBNull(mvarGIANGVIEN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TINH_PHI", DbType.Boolean, clsCommon.GetValueDBNull(mvarTINH_PHI), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@TYPE_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarTYPE_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@TYPE_NOTE", DbType.String, clsCommon.GetValueDBNull(mvarTYPE_NOTE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@ALLOW_EDIT", DbType.Boolean, clsCommon.GetValueDBNull(mvarALLOW_EDIT), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@EDIT_BY_GIAOVU", DbType.Int32, clsCommon.GetValueDBNull(mvarEDIT_BY_GIAOVU), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@GIAOVU_CODE", DbType.String, clsCommon.GetValueDBNull(mvarGIAOVU_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_SESSION_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOGIN_SESSION_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_SESSION", DbType.String, clsCommon.GetValueDBNull(mvarLOGIN_SESSION), ParameterDirection.Input, 1000));

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int DIEMDANH_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_APP_DIEMDANH_LOPHOC;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@DIEMDANH_ID", DbType.Int32, clsCommon.GetValueDBNull(DIEMDANH_ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_APP_DIEMDANH_LOPHOC;
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

        public bool GetByKey(int DIEMDANH_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_APP_DIEMDANH_LOPHOC;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@DIEMDANH_ID", DbType.Int32, clsCommon.GetValueDBNull(DIEMDANH_ID), ParameterDirection.InputOutput, 4));
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

            mvarDIEMDANH_ID = Int32.MinValue;
            mvarNGAY_DIEMDANH = DateTime.MinValue;
            mvarLOPHOC_ID = Int32.MinValue;
            mvarLOPHOC_CODE = string.Empty;
            mvarGIANGVIEN_ID = Int32.MinValue;
            mvarGIANGVIEN_CODE = string.Empty;
            mvarTINH_PHI = false;
            mvarTYPE_ID = Int32.MinValue;
            mvarTYPE_NOTE = string.Empty;
            mvarALLOW_EDIT = false;
            mvarEDIT_BY_GIAOVU = Int32.MinValue;
            mvarGIAOVU_CODE = string.Empty;
            mvarCREATION_DATE = DateTime.MinValue;
            mvarCREATED_BY = Int32.MinValue;
            mvarLAST_UPDATE_DATE = DateTime.MinValue;
            mvarLAST_UPDATED_BY = Int32.MinValue;
            mvarLOGIN_SESSION_ID = Int32.MinValue;
            mvarLOGIN_SESSION = string.Empty;
        }

        public void FillData(DataRow row)
        {

            mvarDIEMDANH_ID = Int32.Parse(clsCommon.GetValue(row["DIEMDANH_ID"], mvarDIEMDANH_ID.GetType().FullName).ToString());
            mvarNGAY_DIEMDANH = DateTime.Parse(clsCommon.GetValue(row["NGAY_DIEMDANH"], mvarNGAY_DIEMDANH.GetType().FullName).ToString());
            mvarLOPHOC_ID = Int32.Parse(clsCommon.GetValue(row["LOPHOC_ID"], mvarLOPHOC_ID.GetType().FullName).ToString());
            mvarLOPHOC_CODE = clsCommon.GetValue(row["LOPHOC_CODE"], mvarLOPHOC_CODE.GetType().FullName).ToString();
            mvarGIANGVIEN_ID = Int32.Parse(clsCommon.GetValue(row["GIANGVIEN_ID"], mvarGIANGVIEN_ID.GetType().FullName).ToString());
            mvarGIANGVIEN_CODE = clsCommon.GetValue(row["GIANGVIEN_CODE"], mvarGIANGVIEN_CODE.GetType().FullName).ToString();
            mvarTINH_PHI = Boolean.Parse(clsCommon.GetValue(row["TINH_PHI"], mvarTINH_PHI.GetType().FullName).ToString());
            mvarTYPE_ID = Int32.Parse(clsCommon.GetValue(row["TYPE_ID"], mvarTYPE_ID.GetType().FullName).ToString());
            mvarTYPE_NOTE = clsCommon.GetValue(row["TYPE_NOTE"], mvarTYPE_NOTE.GetType().FullName).ToString();
            mvarALLOW_EDIT = Boolean.Parse(clsCommon.GetValue(row["ALLOW_EDIT"], mvarALLOW_EDIT.GetType().FullName).ToString());
            mvarEDIT_BY_GIAOVU = Int32.Parse(clsCommon.GetValue(row["EDIT_BY_GIAOVU"], mvarEDIT_BY_GIAOVU.GetType().FullName).ToString());
            mvarGIAOVU_CODE = clsCommon.GetValue(row["GIAOVU_CODE"], mvarGIAOVU_CODE.GetType().FullName).ToString();
            mvarCREATION_DATE = DateTime.Parse(clsCommon.GetValue(row["CREATION_DATE"], mvarCREATION_DATE.GetType().FullName).ToString());
            mvarCREATED_BY = Int32.Parse(clsCommon.GetValue(row["CREATED_BY"], mvarCREATED_BY.GetType().FullName).ToString());
            mvarLAST_UPDATE_DATE = DateTime.Parse(clsCommon.GetValue(row["LAST_UPDATE_DATE"], mvarLAST_UPDATE_DATE.GetType().FullName).ToString());
            mvarLAST_UPDATED_BY = Int32.Parse(clsCommon.GetValue(row["LAST_UPDATED_BY"], mvarLAST_UPDATED_BY.GetType().FullName).ToString());
            mvarLOGIN_SESSION_ID = Int32.Parse(clsCommon.GetValue(row["LOGIN_SESSION_ID"], mvarLOGIN_SESSION_ID.GetType().FullName).ToString());
            mvarLOGIN_SESSION = clsCommon.GetValue(row["LOGIN_SESSION"], mvarLOGIN_SESSION.GetType().FullName).ToString();
        }

        #endregion


        #region "Other Methods"
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        #endregion

    }
}


