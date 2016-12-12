



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsSYS_NGUOIDUNG
    {
        private const string SP_SYS_NGUOIDUNG = "sp_SYS_NGUOIDUNG";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarUSER_ID;
        private string mvarUSER_CODE;
        private string mvarUSER_NAME;
        private Int32 mvarDOMAIN_ID;
        private string mvarDOMAIN_CODE;
        private string mvarUSER_PASSWORD;
        private Boolean mvarENABLED;
        private Boolean mvarIS_EXPIRED;
        private string mvarCAUSE_EXPIRED;
        private string mvarSALT;
        private Boolean mvarALLOW_CHANGE_PASSWORD;
        private DateTime mvarVALIDFROM_DATE;
        private DateTime mvarEXPIRATION_DATE;
        private string mvarEMAILADDRESS;
        private string mvarPHONENUMBER;
        private string mvarIDENTITY_CODE;
        private DateTime mvarLOGIN_TIME;
        private string mvarLOGIN_HOSTNAME;
        private Boolean mvarISLOGIN;
        private DateTime mvarLAST_LOGOUT_TIME;
        private Int32 mvarMINPASSWORDLEN;
        private string mvarUSER_TOKENKEY;
        private Int32 mvarUSER_TYPE;
        private string mvarUSER_TYPE_CODE;
        private Boolean mvarIS_ADMIN;
        private string mvarPASSWORD_QUESTION;
        private string mvarPASSWORD_ANSWER;
        private DateTime mvarCREATION_DATE;
        private Int32 mvarCREATED_BY;
        private DateTime mvarLAST_UPDATE_DATE;
        private Int32 mvarLAST_UPDATED_BY;
        private Int32 mvarNHOMNGUOIDUNG_ID;
        private string mvarNHOMNGUOIDUNG_CODE;
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

        public string USER_NAME
        {
            get { return mvarUSER_NAME; }
            set { mvarUSER_NAME = value; }
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

        public string USER_PASSWORD
        {
            get { return mvarUSER_PASSWORD; }
            set { mvarUSER_PASSWORD = value; }
        }

        public Boolean ENABLED
        {
            get { return mvarENABLED; }
            set { mvarENABLED = value; }
        }

        public Boolean IS_EXPIRED
        {
            get { return mvarIS_EXPIRED; }
            set { mvarIS_EXPIRED = value; }
        }

        public string CAUSE_EXPIRED
        {
            get { return mvarCAUSE_EXPIRED; }
            set { mvarCAUSE_EXPIRED = value; }
        }

        public string SALT
        {
            get { return mvarSALT; }
            set { mvarSALT = value; }
        }

        public Boolean ALLOW_CHANGE_PASSWORD
        {
            get { return mvarALLOW_CHANGE_PASSWORD; }
            set { mvarALLOW_CHANGE_PASSWORD = value; }
        }

        public DateTime VALIDFROM_DATE
        {
            get { return mvarVALIDFROM_DATE; }
            set { mvarVALIDFROM_DATE = value; }
        }

        public DateTime EXPIRATION_DATE
        {
            get { return mvarEXPIRATION_DATE; }
            set { mvarEXPIRATION_DATE = value; }
        }

        public string EMAILADDRESS
        {
            get { return mvarEMAILADDRESS; }
            set { mvarEMAILADDRESS = value; }
        }

        public string PHONENUMBER
        {
            get { return mvarPHONENUMBER; }
            set { mvarPHONENUMBER = value; }
        }

        public string IDENTITY_CODE
        {
            get { return mvarIDENTITY_CODE; }
            set { mvarIDENTITY_CODE = value; }
        }

        public DateTime LOGIN_TIME
        {
            get { return mvarLOGIN_TIME; }
            set { mvarLOGIN_TIME = value; }
        }

        public string LOGIN_HOSTNAME
        {
            get { return mvarLOGIN_HOSTNAME; }
            set { mvarLOGIN_HOSTNAME = value; }
        }

        public Boolean ISLOGIN
        {
            get { return mvarISLOGIN; }
            set { mvarISLOGIN = value; }
        }

        public DateTime LAST_LOGOUT_TIME
        {
            get { return mvarLAST_LOGOUT_TIME; }
            set { mvarLAST_LOGOUT_TIME = value; }
        }

        public Int32 MINPASSWORDLEN
        {
            get { return mvarMINPASSWORDLEN; }
            set { mvarMINPASSWORDLEN = value; }
        }

        public string USER_TOKENKEY
        {
            get { return mvarUSER_TOKENKEY; }
            set { mvarUSER_TOKENKEY = value; }
        }

        public Int32 USER_TYPE
        {
            get { return mvarUSER_TYPE; }
            set { mvarUSER_TYPE = value; }
        }

        public string USER_TYPE_CODE
        {
            get { return mvarUSER_TYPE_CODE; }
            set { mvarUSER_TYPE_CODE = value; }
        }

        public Boolean IS_ADMIN
        {
            get { return mvarIS_ADMIN; }
            set { mvarIS_ADMIN = value; }
        }

        public string PASSWORD_QUESTION
        {
            get { return mvarPASSWORD_QUESTION; }
            set { mvarPASSWORD_QUESTION = value; }
        }

        public string PASSWORD_ANSWER
        {
            get { return mvarPASSWORD_ANSWER; }
            set { mvarPASSWORD_ANSWER = value; }
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

        #endregion

        #region "Constructors"
        public clsSYS_NGUOIDUNG()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsSYS_NGUOIDUNG(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsSYS_NGUOIDUNG(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsSYS_NGUOIDUNG(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = SP_SYS_NGUOIDUNG;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@USER_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSER_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@USER_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarUSER_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@USER_NAME", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarUSER_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarDOMAIN_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarDOMAIN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@USER_PASSWORD", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarUSER_PASSWORD), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@ENABLED", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarENABLED), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@IS_EXPIRED", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarIS_EXPIRED), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@CAUSE_EXPIRED", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarCAUSE_EXPIRED), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@SALT", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarSALT), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@ALLOW_CHANGE_PASSWORD", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarALLOW_CHANGE_PASSWORD), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@VALIDFROM_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarVALIDFROM_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@EXPIRATION_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarEXPIRATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@EMAILADDRESS", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarEMAILADDRESS), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@PHONENUMBER", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarPHONENUMBER), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@IDENTITY_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarIDENTITY_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_TIME", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarLOGIN_TIME), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_HOSTNAME", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLOGIN_HOSTNAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@ISLOGIN", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarISLOGIN), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@LAST_LOGOUT_TIME", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_LOGOUT_TIME), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@MINPASSWORDLEN", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarMINPASSWORDLEN), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USER_TOKENKEY", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarUSER_TOKENKEY), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@USER_TYPE", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSER_TYPE), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USER_TYPE_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarUSER_TYPE_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@IS_ADMIN", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarIS_ADMIN), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@PASSWORD_QUESTION", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarPASSWORD_QUESTION), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@PASSWORD_ANSWER", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarPASSWORD_ANSWER), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarNHOMNGUOIDUNG_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarNHOMNGUOIDUNG_CODE), ParameterDirection.Input, 1000));

                DAL.ExecNonQuery();

                mvarUSER_ID = Int32.Parse(UTILITIES.clsCommon.GetValue(DAL.Parameters.Items("@USER_ID").Value, mvarUSER_ID.GetType().FullName).ToString());

                return (mvarUSER_ID > 0);
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
                DAL.CommandText = SP_SYS_NGUOIDUNG;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@USER_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSER_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@USER_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarUSER_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@USER_NAME", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarUSER_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarDOMAIN_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@DOMAIN_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarDOMAIN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@USER_PASSWORD", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarUSER_PASSWORD), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@ENABLED", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarENABLED), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@IS_EXPIRED", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarIS_EXPIRED), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@CAUSE_EXPIRED", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarCAUSE_EXPIRED), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@SALT", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarSALT), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@ALLOW_CHANGE_PASSWORD", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarALLOW_CHANGE_PASSWORD), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@VALIDFROM_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarVALIDFROM_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@EXPIRATION_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarEXPIRATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@EMAILADDRESS", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarEMAILADDRESS), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@PHONENUMBER", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarPHONENUMBER), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@IDENTITY_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarIDENTITY_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_TIME", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarLOGIN_TIME), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_HOSTNAME", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLOGIN_HOSTNAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@ISLOGIN", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarISLOGIN), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@LAST_LOGOUT_TIME", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_LOGOUT_TIME), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@MINPASSWORDLEN", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarMINPASSWORDLEN), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USER_TOKENKEY", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarUSER_TOKENKEY), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@USER_TYPE", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSER_TYPE), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USER_TYPE_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarUSER_TYPE_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@IS_ADMIN", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarIS_ADMIN), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@PASSWORD_QUESTION", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarPASSWORD_QUESTION), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@PASSWORD_ANSWER", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarPASSWORD_ANSWER), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarNHOMNGUOIDUNG_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarNHOMNGUOIDUNG_CODE), ParameterDirection.Input, 1000));

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int USER_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_NGUOIDUNG;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@USER_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(USER_ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_SYS_NGUOIDUNG;
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

        public bool GetByKey(int USER_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_NGUOIDUNG;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@USER_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(USER_ID), ParameterDirection.InputOutput, 4));
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

            mvarUSER_ID = Int32.MinValue;
            mvarUSER_CODE = string.Empty;
            mvarUSER_NAME = string.Empty;
            mvarDOMAIN_ID = Int32.MinValue;
            mvarDOMAIN_CODE = string.Empty;
            mvarUSER_PASSWORD = string.Empty;
            mvarENABLED = false;
            mvarIS_EXPIRED = false;
            mvarCAUSE_EXPIRED = string.Empty;
            mvarSALT = string.Empty;
            mvarALLOW_CHANGE_PASSWORD = false;
            mvarVALIDFROM_DATE = DateTime.MinValue;
            mvarEXPIRATION_DATE = DateTime.MinValue;
            mvarEMAILADDRESS = string.Empty;
            mvarPHONENUMBER = string.Empty;
            mvarIDENTITY_CODE = string.Empty;
            mvarLOGIN_TIME = DateTime.MinValue;
            mvarLOGIN_HOSTNAME = string.Empty;
            mvarISLOGIN = false;
            mvarLAST_LOGOUT_TIME = DateTime.MinValue;
            mvarMINPASSWORDLEN = Int32.MinValue;
            mvarUSER_TOKENKEY = string.Empty;
            mvarUSER_TYPE = Int32.MinValue;
            mvarUSER_TYPE_CODE = string.Empty;
            mvarIS_ADMIN = false;
            mvarPASSWORD_QUESTION = string.Empty;
            mvarPASSWORD_ANSWER = string.Empty;
            mvarCREATION_DATE = DateTime.MinValue;
            mvarCREATED_BY = Int32.MinValue;
            mvarLAST_UPDATE_DATE = DateTime.MinValue;
            mvarLAST_UPDATED_BY = Int32.MinValue;
            mvarNHOMNGUOIDUNG_ID = Int32.MinValue;
            mvarNHOMNGUOIDUNG_CODE = string.Empty;
        }

        public void FillData(DataRow row)
        {

            mvarUSER_ID = Int32.Parse(UTILITIES.clsCommon.GetValue(row["USER_ID"], mvarUSER_ID.GetType().FullName).ToString());
            mvarUSER_CODE = UTILITIES.clsCommon.GetValue(row["USER_CODE"], mvarUSER_CODE.GetType().FullName).ToString();
            mvarUSER_NAME = UTILITIES.clsCommon.GetValue(row["USER_NAME"], mvarUSER_NAME.GetType().FullName).ToString();
            mvarDOMAIN_ID = Int32.Parse(UTILITIES.clsCommon.GetValue(row["DOMAIN_ID"], mvarDOMAIN_ID.GetType().FullName).ToString());
            mvarDOMAIN_CODE = UTILITIES.clsCommon.GetValue(row["DOMAIN_CODE"], mvarDOMAIN_CODE.GetType().FullName).ToString();
            mvarUSER_PASSWORD = UTILITIES.clsCommon.GetValue(row["USER_PASSWORD"], mvarUSER_PASSWORD.GetType().FullName).ToString();
            mvarENABLED = Boolean.Parse(UTILITIES.clsCommon.GetValue(row["ENABLED"], mvarENABLED.GetType().FullName).ToString());
            mvarIS_EXPIRED = Boolean.Parse(UTILITIES.clsCommon.GetValue(row["IS_EXPIRED"], mvarIS_EXPIRED.GetType().FullName).ToString());
            mvarCAUSE_EXPIRED = UTILITIES.clsCommon.GetValue(row["CAUSE_EXPIRED"], mvarCAUSE_EXPIRED.GetType().FullName).ToString();
            mvarSALT = UTILITIES.clsCommon.GetValue(row["SALT"], mvarSALT.GetType().FullName).ToString();
            mvarALLOW_CHANGE_PASSWORD = Boolean.Parse(UTILITIES.clsCommon.GetValue(row["ALLOW_CHANGE_PASSWORD"], mvarALLOW_CHANGE_PASSWORD.GetType().FullName).ToString());
            mvarVALIDFROM_DATE = DateTime.Parse(UTILITIES.clsCommon.GetValue(row["VALIDFROM_DATE"], mvarVALIDFROM_DATE.GetType().FullName).ToString());
            mvarEXPIRATION_DATE = DateTime.Parse(UTILITIES.clsCommon.GetValue(row["EXPIRATION_DATE"], mvarEXPIRATION_DATE.GetType().FullName).ToString());
            mvarEMAILADDRESS = UTILITIES.clsCommon.GetValue(row["EMAILADDRESS"], mvarEMAILADDRESS.GetType().FullName).ToString();
            mvarPHONENUMBER = UTILITIES.clsCommon.GetValue(row["PHONENUMBER"], mvarPHONENUMBER.GetType().FullName).ToString();
            mvarIDENTITY_CODE = UTILITIES.clsCommon.GetValue(row["IDENTITY_CODE"], mvarIDENTITY_CODE.GetType().FullName).ToString();
            mvarLOGIN_TIME = DateTime.Parse(UTILITIES.clsCommon.GetValue(row["LOGIN_TIME"], mvarLOGIN_TIME.GetType().FullName).ToString());
            mvarLOGIN_HOSTNAME = UTILITIES.clsCommon.GetValue(row["LOGIN_HOSTNAME"], mvarLOGIN_HOSTNAME.GetType().FullName).ToString();
            mvarISLOGIN = Boolean.Parse(UTILITIES.clsCommon.GetValue(row["ISLOGIN"], mvarISLOGIN.GetType().FullName).ToString());
            mvarLAST_LOGOUT_TIME = DateTime.Parse(UTILITIES.clsCommon.GetValue(row["LAST_LOGOUT_TIME"], mvarLAST_LOGOUT_TIME.GetType().FullName).ToString());
            mvarMINPASSWORDLEN = Int32.Parse(UTILITIES.clsCommon.GetValue(row["MINPASSWORDLEN"], mvarMINPASSWORDLEN.GetType().FullName).ToString());
            mvarUSER_TOKENKEY = UTILITIES.clsCommon.GetValue(row["USER_TOKENKEY"], mvarUSER_TOKENKEY.GetType().FullName).ToString();
            mvarUSER_TYPE = Int32.Parse(UTILITIES.clsCommon.GetValue(row["USER_TYPE"], mvarUSER_TYPE.GetType().FullName).ToString());
            mvarUSER_TYPE_CODE = UTILITIES.clsCommon.GetValue(row["USER_TYPE_CODE"], mvarUSER_TYPE_CODE.GetType().FullName).ToString();
            mvarIS_ADMIN = Boolean.Parse(UTILITIES.clsCommon.GetValue(row["IS_ADMIN"], mvarIS_ADMIN.GetType().FullName).ToString());
            mvarPASSWORD_QUESTION = UTILITIES.clsCommon.GetValue(row["PASSWORD_QUESTION"], mvarPASSWORD_QUESTION.GetType().FullName).ToString();
            mvarPASSWORD_ANSWER = UTILITIES.clsCommon.GetValue(row["PASSWORD_ANSWER"], mvarPASSWORD_ANSWER.GetType().FullName).ToString();
            mvarCREATION_DATE = DateTime.Parse(UTILITIES.clsCommon.GetValue(row["CREATION_DATE"], mvarCREATION_DATE.GetType().FullName).ToString());
            mvarCREATED_BY = Int32.Parse(UTILITIES.clsCommon.GetValue(row["CREATED_BY"], mvarCREATED_BY.GetType().FullName).ToString());
            mvarLAST_UPDATE_DATE = DateTime.Parse(UTILITIES.clsCommon.GetValue(row["LAST_UPDATE_DATE"], mvarLAST_UPDATE_DATE.GetType().FullName).ToString());
            mvarLAST_UPDATED_BY = Int32.Parse(UTILITIES.clsCommon.GetValue(row["LAST_UPDATED_BY"], mvarLAST_UPDATED_BY.GetType().FullName).ToString());
            mvarNHOMNGUOIDUNG_ID = Int32.Parse(UTILITIES.clsCommon.GetValue(row["NHOMNGUOIDUNG_ID"], mvarNHOMNGUOIDUNG_ID.GetType().FullName).ToString());
            mvarNHOMNGUOIDUNG_CODE = UTILITIES.clsCommon.GetValue(row["NHOMNGUOIDUNG_CODE"], mvarNHOMNGUOIDUNG_CODE.GetType().FullName).ToString();
        }

        #endregion	

        #region "Other Methods"
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        public bool GetByUserCode(string strUserCode)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_NGUOIDUNG;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByCode", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@USER_CODE", DbType.String, clsCommon.GetValueDBNull(strUserCode), ParameterDirection.Input, 1000));
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

        
        #endregion

    }
}


