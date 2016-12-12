



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsSYS_LOGIN_SESSIONS
    {
        private const string SP_SYS_LOGIN_SESSIONS = "sp_SYS_LOGIN_SESSIONS";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarLOGIN_SESSION_ID;
        private Int32 mvarUSER_ID;
        private string mvarUSER_CODE;
        private string mvarHOST_NAME;
        private string mvarIP_ADDRESS;
        private DateTime mvarLOGIN_DATE;
        private string mvarTOKEN_KEY;
        private DateTime mvarLOGOUT_DATE;
        private Int32 mvarDOMAIN_ID;
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

        public Int32 LOGIN_SESSION_ID
        {
            get { return mvarLOGIN_SESSION_ID; }
            set { mvarLOGIN_SESSION_ID = value; }
        }

        public Int32 USER_ID
        {
            get { return mvarUSER_ID; }
            set { mvarUSER_ID = value; }
        }

        public string USER_CODE
        {
            get { return mvarUSER_CODE; }
            set { mvarUSER_CODE = value; }
        }

        public string HOST_NAME
        {
            get { return mvarHOST_NAME; }
            set { mvarHOST_NAME = value; }
        }

        public string IP_ADDRESS
        {
            get { return mvarIP_ADDRESS; }
            set { mvarIP_ADDRESS = value; }
        }

        public DateTime LOGIN_DATE
        {
            get { return mvarLOGIN_DATE; }
            set { mvarLOGIN_DATE = value; }
        }

        public string TOKEN_KEY
        {
            get { return mvarTOKEN_KEY; }
            set { mvarTOKEN_KEY = value; }
        }

        public DateTime LOGOUT_DATE
        {
            get { return mvarLOGOUT_DATE; }
            set { mvarLOGOUT_DATE = value; }
        }

        public Int32 DOMAIN_ID
        {
            get { return mvarDOMAIN_ID; }
            set { mvarDOMAIN_ID = value; }
        }

        #endregion


        #region "Constructors"
        public clsSYS_LOGIN_SESSIONS()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsSYS_LOGIN_SESSIONS(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsSYS_LOGIN_SESSIONS(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsSYS_LOGIN_SESSIONS(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = SP_SYS_LOGIN_SESSIONS;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@LOGIN_SESSION_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOGIN_SESSION_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@USER_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSER_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USER_CODE", DbType.String, clsCommon.GetValueDBNull(mvarUSER_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@HOST_NAME", DbType.String, clsCommon.GetValueDBNull(mvarHOST_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@IP_ADDRESS", DbType.String, clsCommon.GetValueDBNull(mvarIP_ADDRESS), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLOGIN_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@TOKEN_KEY", DbType.String, clsCommon.GetValueDBNull(mvarTOKEN_KEY), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@LOGOUT_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLOGOUT_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarDOMAIN_ID), ParameterDirection.Input, 4));

                DAL.ExecNonQuery();

                mvarLOGIN_SESSION_ID = Int32.Parse(clsCommon.GetValue(DAL.Parameters.Items("@LOGIN_SESSION_ID").Value, mvarLOGIN_SESSION_ID.GetType().FullName).ToString());

                return (mvarLOGIN_SESSION_ID > 0);
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
                DAL.CommandText = SP_SYS_LOGIN_SESSIONS;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@LOGIN_SESSION_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOGIN_SESSION_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@USER_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSER_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USER_CODE", DbType.String, clsCommon.GetValueDBNull(mvarUSER_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@HOST_NAME", DbType.String, clsCommon.GetValueDBNull(mvarHOST_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@IP_ADDRESS", DbType.String, clsCommon.GetValueDBNull(mvarIP_ADDRESS), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLOGIN_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@TOKEN_KEY", DbType.String, clsCommon.GetValueDBNull(mvarTOKEN_KEY), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@LOGOUT_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLOGOUT_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarDOMAIN_ID), ParameterDirection.Input, 4));

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int LOGIN_SESSION_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_LOGIN_SESSIONS;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_SESSION_ID", DbType.Int32, clsCommon.GetValueDBNull(LOGIN_SESSION_ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_SYS_LOGIN_SESSIONS;
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

        public bool GetByKey(int LOGIN_SESSION_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_LOGIN_SESSIONS;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@LOGIN_SESSION_ID", DbType.Int32, clsCommon.GetValueDBNull(LOGIN_SESSION_ID), ParameterDirection.InputOutput, 4));
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

            mvarLOGIN_SESSION_ID = Int32.MinValue;
            mvarUSER_ID = Int32.MinValue;
            mvarUSER_CODE = string.Empty;
            mvarHOST_NAME = string.Empty;
            mvarIP_ADDRESS = string.Empty;
            mvarLOGIN_DATE = DateTime.MinValue;
            mvarTOKEN_KEY = string.Empty;
            mvarLOGOUT_DATE = DateTime.MinValue;
            mvarDOMAIN_ID = Int32.MinValue;
        }

        public void FillData(DataRow row)
        {

            mvarLOGIN_SESSION_ID = Int32.Parse(clsCommon.GetValue(row["LOGIN_SESSION_ID"], mvarLOGIN_SESSION_ID.GetType().FullName).ToString());
            mvarUSER_ID = Int32.Parse(clsCommon.GetValue(row["USER_ID"], mvarUSER_ID.GetType().FullName).ToString());
            mvarUSER_CODE = clsCommon.GetValue(row["USER_CODE"], mvarUSER_CODE.GetType().FullName).ToString();
            mvarHOST_NAME = clsCommon.GetValue(row["HOST_NAME"], mvarHOST_NAME.GetType().FullName).ToString();
            mvarIP_ADDRESS = clsCommon.GetValue(row["IP_ADDRESS"], mvarIP_ADDRESS.GetType().FullName).ToString();
            mvarLOGIN_DATE = DateTime.Parse(clsCommon.GetValue(row["LOGIN_DATE"], mvarLOGIN_DATE.GetType().FullName).ToString());
            mvarTOKEN_KEY = clsCommon.GetValue(row["TOKEN_KEY"], mvarTOKEN_KEY.GetType().FullName).ToString();
            mvarLOGOUT_DATE = DateTime.Parse(clsCommon.GetValue(row["LOGOUT_DATE"], mvarLOGOUT_DATE.GetType().FullName).ToString());
            mvarDOMAIN_ID = Int32.Parse(clsCommon.GetValue(row["DOMAIN_ID"], mvarDOMAIN_ID.GetType().FullName).ToString());
        }

        #endregion


        #region "Other Methods"
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        #endregion

    }
}


