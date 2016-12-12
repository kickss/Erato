



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsSYS_DICTIONARY
    {
        private const string SP_SYS_DICTIONARY = "sp_SYS_DICTIONARY";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarDICTIONARY_ID;
        private Int32 mvarDICTIONARY_TYPE_ID;
        private string mvarDICTIONARY_TYPE_CODE;
        private string mvarDICTIONARY_CODE;
        private string mvarDICTIONARY_NAME;
        private string mvarDICTIONARY_NAME_EN;
        private string mvarLATIN_NAME;
        private Int32 mvarPARENT_ID;
        private Int32 mvarIDX;
        private Boolean mvarENABLED;
        private Int32 mvarATTRIBUTE_01;
        private DateTime mvarATTRIBUTE_02;
        private Decimal mvarATTRIBUTE_03;
        private string mvarATTRIBUTE_04;
        private DateTime mvarCREATION_DATE;
        private Int32 mvarCREATED_BY;
        private DateTime mvarLAST_UPDATE_DATE;
        private Int32 mvarLAST_UPDATED_BY;
        private Int32 mvarBENHVIEN_ID;
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

        public Int32 DICTIONARY_ID
        {
            get { return mvarDICTIONARY_ID; }
            set { mvarDICTIONARY_ID = value; }
        }

        public Int32 DICTIONARY_TYPE_ID
        {
            get { return mvarDICTIONARY_TYPE_ID; }
            set { mvarDICTIONARY_TYPE_ID = value; }
        }

        public string DICTIONARY_TYPE_CODE
        {
            get { return mvarDICTIONARY_TYPE_CODE; }
            set { mvarDICTIONARY_TYPE_CODE = value; }
        }

        public string DICTIONARY_CODE
        {
            get { return mvarDICTIONARY_CODE; }
            set { mvarDICTIONARY_CODE = value; }
        }

        public string DICTIONARY_NAME
        {
            get { return mvarDICTIONARY_NAME; }
            set { mvarDICTIONARY_NAME = value; }
        }

        public string DICTIONARY_NAME_EN
        {
            get { return mvarDICTIONARY_NAME_EN; }
            set { mvarDICTIONARY_NAME_EN = value; }
        }

        public string LATIN_NAME
        {
            get { return mvarLATIN_NAME; }
            set { mvarLATIN_NAME = value; }
        }

        public Int32 PARENT_ID
        {
            get { return mvarPARENT_ID; }
            set { mvarPARENT_ID = value; }
        }

        public Int32 IDX
        {
            get { return mvarIDX; }
            set { mvarIDX = value; }
        }

        public Boolean ENABLED
        {
            get { return mvarENABLED; }
            set { mvarENABLED = value; }
        }

        public Int32 ATTRIBUTE_01
        {
            get { return mvarATTRIBUTE_01; }
            set { mvarATTRIBUTE_01 = value; }
        }

        public DateTime ATTRIBUTE_02
        {
            get { return mvarATTRIBUTE_02; }
            set { mvarATTRIBUTE_02 = value; }
        }

        public Decimal ATTRIBUTE_03
        {
            get { return mvarATTRIBUTE_03; }
            set { mvarATTRIBUTE_03 = value; }
        }

        public string ATTRIBUTE_04
        {
            get { return mvarATTRIBUTE_04; }
            set { mvarATTRIBUTE_04 = value; }
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

        public Int32 BENHVIEN_ID
        {
            get { return mvarBENHVIEN_ID; }
            set { mvarBENHVIEN_ID = value; }
        }

        #endregion

        #region "Constructors"
        public clsSYS_DICTIONARY()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsSYS_DICTIONARY(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsSYS_DICTIONARY(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsSYS_DICTIONARY(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = SP_SYS_DICTIONARY;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@DICTIONARY_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarDICTIONARY_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@DICTIONARY_TYPE_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarDICTIONARY_TYPE_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@DICTIONARY_TYPE_CODE", DbType.String, clsCommon.GetValueDBNull(mvarDICTIONARY_TYPE_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DICTIONARY_CODE", DbType.String, clsCommon.GetValueDBNull(mvarDICTIONARY_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DICTIONARY_NAME", DbType.String, clsCommon.GetValueDBNull(mvarDICTIONARY_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DICTIONARY_NAME_EN", DbType.String, clsCommon.GetValueDBNull(mvarDICTIONARY_NAME_EN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@LATIN_NAME", DbType.String, clsCommon.GetValueDBNull(mvarLATIN_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@PARENT_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarPARENT_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@IDX", DbType.Int32, clsCommon.GetValueDBNull(mvarIDX), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@ENABLED", DbType.Boolean, clsCommon.GetValueDBNull(mvarENABLED), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@ATTRIBUTE_01", DbType.Int32, clsCommon.GetValueDBNull(mvarATTRIBUTE_01), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@ATTRIBUTE_02", DbType.DateTime, clsCommon.GetValueDBNull(mvarATTRIBUTE_02), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@ATTRIBUTE_03", DbType.Decimal, clsCommon.GetValueDBNull(mvarATTRIBUTE_03), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@ATTRIBUTE_04", DbType.String, clsCommon.GetValueDBNull(mvarATTRIBUTE_04), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@BENHVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarBENHVIEN_ID), ParameterDirection.Input, 4));

                DAL.ExecNonQuery();

                mvarDICTIONARY_ID = Int32.Parse(clsCommon.GetValue(DAL.Parameters.Items("@DICTIONARY_ID").Value, mvarDICTIONARY_ID.GetType().FullName).ToString());

                return (mvarDICTIONARY_ID > 0);
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
                DAL.CommandText = SP_SYS_DICTIONARY;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@DICTIONARY_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarDICTIONARY_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@DICTIONARY_TYPE_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarDICTIONARY_TYPE_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@DICTIONARY_TYPE_CODE", DbType.String, clsCommon.GetValueDBNull(mvarDICTIONARY_TYPE_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DICTIONARY_CODE", DbType.String, clsCommon.GetValueDBNull(mvarDICTIONARY_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DICTIONARY_NAME", DbType.String, clsCommon.GetValueDBNull(mvarDICTIONARY_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DICTIONARY_NAME_EN", DbType.String, clsCommon.GetValueDBNull(mvarDICTIONARY_NAME_EN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@LATIN_NAME", DbType.String, clsCommon.GetValueDBNull(mvarLATIN_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@PARENT_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarPARENT_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@IDX", DbType.Int32, clsCommon.GetValueDBNull(mvarIDX), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@ENABLED", DbType.Boolean, clsCommon.GetValueDBNull(mvarENABLED), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@ATTRIBUTE_01", DbType.Int32, clsCommon.GetValueDBNull(mvarATTRIBUTE_01), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@ATTRIBUTE_02", DbType.DateTime, clsCommon.GetValueDBNull(mvarATTRIBUTE_02), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@ATTRIBUTE_03", DbType.Decimal, clsCommon.GetValueDBNull(mvarATTRIBUTE_03), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@ATTRIBUTE_04", DbType.String, clsCommon.GetValueDBNull(mvarATTRIBUTE_04), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@BENHVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarBENHVIEN_ID), ParameterDirection.Input, 4));

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int DICTIONARY_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_DICTIONARY;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@DICTIONARY_ID", DbType.Int32, clsCommon.GetValueDBNull(DICTIONARY_ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_SYS_DICTIONARY;
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

        public bool GetByKey(int DICTIONARY_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_DICTIONARY;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@DICTIONARY_ID", DbType.Int32, clsCommon.GetValueDBNull(DICTIONARY_ID), ParameterDirection.InputOutput, 4));
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

            mvarDICTIONARY_ID = Int32.MinValue;
            mvarDICTIONARY_TYPE_ID = Int32.MinValue;
            mvarDICTIONARY_TYPE_CODE = string.Empty;
            mvarDICTIONARY_CODE = string.Empty;
            mvarDICTIONARY_NAME = string.Empty;
            mvarDICTIONARY_NAME_EN = string.Empty;
            mvarLATIN_NAME = string.Empty;
            mvarPARENT_ID = Int32.MinValue;
            mvarIDX = Int32.MinValue;
            mvarENABLED = false;
            mvarATTRIBUTE_01 = Int32.MinValue;
            mvarATTRIBUTE_02 = DateTime.MinValue;
            mvarATTRIBUTE_03 = Decimal.MinValue;
            mvarATTRIBUTE_04 = string.Empty;
            mvarCREATION_DATE = DateTime.MinValue;
            mvarCREATED_BY = Int32.MinValue;
            mvarLAST_UPDATE_DATE = DateTime.MinValue;
            mvarLAST_UPDATED_BY = Int32.MinValue;
            mvarBENHVIEN_ID = Int32.MinValue;
        }

        public void FillData(DataRow row)
        {

            mvarDICTIONARY_ID = Int32.Parse(clsCommon.GetValue(row["DICTIONARY_ID"], mvarDICTIONARY_ID.GetType().FullName).ToString());
            mvarDICTIONARY_TYPE_ID = Int32.Parse(clsCommon.GetValue(row["DICTIONARY_TYPE_ID"], mvarDICTIONARY_TYPE_ID.GetType().FullName).ToString());
            mvarDICTIONARY_TYPE_CODE = clsCommon.GetValue(row["DICTIONARY_TYPE_CODE"], mvarDICTIONARY_TYPE_CODE.GetType().FullName).ToString();
            mvarDICTIONARY_CODE = clsCommon.GetValue(row["DICTIONARY_CODE"], mvarDICTIONARY_CODE.GetType().FullName).ToString();
            mvarDICTIONARY_NAME = clsCommon.GetValue(row["DICTIONARY_NAME"], mvarDICTIONARY_NAME.GetType().FullName).ToString();
            mvarDICTIONARY_NAME_EN = clsCommon.GetValue(row["DICTIONARY_NAME_EN"], mvarDICTIONARY_NAME_EN.GetType().FullName).ToString();
            mvarLATIN_NAME = clsCommon.GetValue(row["LATIN_NAME"], mvarLATIN_NAME.GetType().FullName).ToString();
            mvarPARENT_ID = Int32.Parse(clsCommon.GetValue(row["PARENT_ID"], mvarPARENT_ID.GetType().FullName).ToString());
            mvarIDX = Int32.Parse(clsCommon.GetValue(row["IDX"], mvarIDX.GetType().FullName).ToString());
            mvarENABLED = Boolean.Parse(clsCommon.GetValue(row["ENABLED"], mvarENABLED.GetType().FullName).ToString());
            mvarATTRIBUTE_01 = Int32.Parse(clsCommon.GetValue(row["ATTRIBUTE_01"], mvarATTRIBUTE_01.GetType().FullName).ToString());
            mvarATTRIBUTE_02 = DateTime.Parse(clsCommon.GetValue(row["ATTRIBUTE_02"], mvarATTRIBUTE_02.GetType().FullName).ToString());
            mvarATTRIBUTE_03 = Decimal.Parse(clsCommon.GetValue(row["ATTRIBUTE_03"], mvarATTRIBUTE_03.GetType().FullName).ToString());
            mvarATTRIBUTE_04 = clsCommon.GetValue(row["ATTRIBUTE_04"], mvarATTRIBUTE_04.GetType().FullName).ToString();
            mvarCREATION_DATE = DateTime.Parse(clsCommon.GetValue(row["CREATION_DATE"], mvarCREATION_DATE.GetType().FullName).ToString());
            mvarCREATED_BY = Int32.Parse(clsCommon.GetValue(row["CREATED_BY"], mvarCREATED_BY.GetType().FullName).ToString());
            mvarLAST_UPDATE_DATE = DateTime.Parse(clsCommon.GetValue(row["LAST_UPDATE_DATE"], mvarLAST_UPDATE_DATE.GetType().FullName).ToString());
            mvarLAST_UPDATED_BY = Int32.Parse(clsCommon.GetValue(row["LAST_UPDATED_BY"], mvarLAST_UPDATED_BY.GetType().FullName).ToString());
            mvarBENHVIEN_ID = Int32.Parse(clsCommon.GetValue(row["BENHVIEN_ID"], mvarBENHVIEN_ID.GetType().FullName).ToString());
        }

        #endregion

        #region "Other Methods"
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        public DataTable GetDictionaryByDictionary_Code(string strDictionaryCode)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_DICTIONARY;
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
        #endregion

    }
}


