



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsSYS_DOMAINS
    {
        private const string SP_SYS_DOMAINS = "sp_SYS_DOMAINS";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarDOMAIN_ID;
        private string mvarDOMAIN_CODE;
        private Int32 mvarDOMAIN_PARENT_ID;
        private string mvarDOMAIN_NAME;
        private Boolean mvarENABLED;
        private string mvarDESCRIPTION;
        private string mvarDOMAIN_ADDRESS;
        private string mvarDOMAIN_OWENER;
        private string mvarVALUE_CODE;
        private string mvarVALUE_NAME;
        private Int32 mvarVALUE_ID;
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

        public Int32 DOMAIN_ID
        {
            get { return mvarDOMAIN_ID; }
            set { mvarDOMAIN_ID = value; }
        }

        public string DOMAIN_CODE
        {
            get { return mvarDOMAIN_CODE; }
            set { mvarDOMAIN_CODE = value; }
        }

        public Int32 DOMAIN_PARENT_ID
        {
            get { return mvarDOMAIN_PARENT_ID; }
            set { mvarDOMAIN_PARENT_ID = value; }
        }

        public string DOMAIN_NAME
        {
            get { return mvarDOMAIN_NAME; }
            set { mvarDOMAIN_NAME = value; }
        }

        public Boolean ENABLED
        {
            get { return mvarENABLED; }
            set { mvarENABLED = value; }
        }

        public string DESCRIPTION
        {
            get { return mvarDESCRIPTION; }
            set { mvarDESCRIPTION = value; }
        }

        public string DOMAIN_ADDRESS
        {
            get { return mvarDOMAIN_ADDRESS; }
            set { mvarDOMAIN_ADDRESS = value; }
        }

        public string DOMAIN_OWENER
        {
            get { return mvarDOMAIN_OWENER; }
            set { mvarDOMAIN_OWENER = value; }
        }

        public string VALUE_CODE
        {
            get { return mvarVALUE_CODE; }
            set { mvarVALUE_CODE = value; }
        }

        public string VALUE_NAME
        {
            get { return mvarVALUE_NAME; }
            set { mvarVALUE_NAME = value; }
        }

        public Int32 VALUE_ID
        {
            get { return mvarVALUE_ID; }
            set { mvarVALUE_ID = value; }
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
        public clsSYS_DOMAINS()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsSYS_DOMAINS(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsSYS_DOMAINS(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsSYS_DOMAINS(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = SP_SYS_DOMAINS;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@DOMAIN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarDOMAIN_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_CODE", DbType.String, clsCommon.GetValueDBNull(mvarDOMAIN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_PARENT_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarDOMAIN_PARENT_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_NAME", DbType.String, clsCommon.GetValueDBNull(mvarDOMAIN_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@ENABLED", DbType.Boolean, clsCommon.GetValueDBNull(mvarENABLED), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@DESCRIPTION", DbType.String, clsCommon.GetValueDBNull(mvarDESCRIPTION), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_ADDRESS", DbType.String, clsCommon.GetValueDBNull(mvarDOMAIN_ADDRESS), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_OWENER", DbType.String, clsCommon.GetValueDBNull(mvarDOMAIN_OWENER), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@VALUE_CODE", DbType.String, clsCommon.GetValueDBNull(mvarVALUE_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@VALUE_NAME", DbType.String, clsCommon.GetValueDBNull(mvarVALUE_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@VALUE_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarVALUE_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));

                DAL.ExecNonQuery();

                mvarDOMAIN_ID = Int32.Parse(clsCommon.GetValue(DAL.Parameters.Items("@DOMAIN_ID").Value, mvarDOMAIN_ID.GetType().FullName).ToString());

                return (mvarDOMAIN_ID > 0);
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
                DAL.CommandText = SP_SYS_DOMAINS;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@DOMAIN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarDOMAIN_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_CODE", DbType.String, clsCommon.GetValueDBNull(mvarDOMAIN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_PARENT_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarDOMAIN_PARENT_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_NAME", DbType.String, clsCommon.GetValueDBNull(mvarDOMAIN_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@ENABLED", DbType.Boolean, clsCommon.GetValueDBNull(mvarENABLED), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@DESCRIPTION", DbType.String, clsCommon.GetValueDBNull(mvarDESCRIPTION), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_ADDRESS", DbType.String, clsCommon.GetValueDBNull(mvarDOMAIN_ADDRESS), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_OWENER", DbType.String, clsCommon.GetValueDBNull(mvarDOMAIN_OWENER), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@VALUE_CODE", DbType.String, clsCommon.GetValueDBNull(mvarVALUE_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@VALUE_NAME", DbType.String, clsCommon.GetValueDBNull(mvarVALUE_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@VALUE_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarVALUE_ID), ParameterDirection.Input, 4));
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

        public bool Delete(int DOMAIN_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_DOMAINS;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_ID", DbType.Int32, clsCommon.GetValueDBNull(DOMAIN_ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_SYS_DOMAINS;
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

        public bool GetByKey(int DOMAIN_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_DOMAINS;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@DOMAIN_ID", DbType.Int32, clsCommon.GetValueDBNull(DOMAIN_ID), ParameterDirection.InputOutput, 4));
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

            mvarDOMAIN_ID = Int32.MinValue;
            mvarDOMAIN_CODE = string.Empty;
            mvarDOMAIN_PARENT_ID = Int32.MinValue;
            mvarDOMAIN_NAME = string.Empty;
            mvarENABLED = false;
            mvarDESCRIPTION = string.Empty;
            mvarDOMAIN_ADDRESS = string.Empty;
            mvarDOMAIN_OWENER = string.Empty;
            mvarVALUE_CODE = string.Empty;
            mvarVALUE_NAME = string.Empty;
            mvarVALUE_ID = Int32.MinValue;
            mvarCREATION_DATE = DateTime.MinValue;
            mvarCREATED_BY = Int32.MinValue;
            mvarLAST_UPDATE_DATE = DateTime.MinValue;
            mvarLAST_UPDATED_BY = Int32.MinValue;
        }

        public void FillData(DataRow row)
        {

            mvarDOMAIN_ID = Int32.Parse(clsCommon.GetValue(row["DOMAIN_ID"], mvarDOMAIN_ID.GetType().FullName).ToString());
            mvarDOMAIN_CODE = clsCommon.GetValue(row["DOMAIN_CODE"], mvarDOMAIN_CODE.GetType().FullName).ToString();
            mvarDOMAIN_PARENT_ID = Int32.Parse(clsCommon.GetValue(row["DOMAIN_PARENT_ID"], mvarDOMAIN_PARENT_ID.GetType().FullName).ToString());
            mvarDOMAIN_NAME = clsCommon.GetValue(row["DOMAIN_NAME"], mvarDOMAIN_NAME.GetType().FullName).ToString();
            mvarENABLED = Boolean.Parse(clsCommon.GetValue(row["ENABLED"], mvarENABLED.GetType().FullName).ToString());
            mvarDESCRIPTION = clsCommon.GetValue(row["DESCRIPTION"], mvarDESCRIPTION.GetType().FullName).ToString();
            mvarDOMAIN_ADDRESS = clsCommon.GetValue(row["DOMAIN_ADDRESS"], mvarDOMAIN_ADDRESS.GetType().FullName).ToString();
            mvarDOMAIN_OWENER = clsCommon.GetValue(row["DOMAIN_OWENER"], mvarDOMAIN_OWENER.GetType().FullName).ToString();
            mvarVALUE_CODE = clsCommon.GetValue(row["VALUE_CODE"], mvarVALUE_CODE.GetType().FullName).ToString();
            mvarVALUE_NAME = clsCommon.GetValue(row["VALUE_NAME"], mvarVALUE_NAME.GetType().FullName).ToString();
            mvarVALUE_ID = Int32.Parse(clsCommon.GetValue(row["VALUE_ID"], mvarVALUE_ID.GetType().FullName).ToString());
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


