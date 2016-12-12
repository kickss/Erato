using System;
using System.Data;
using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsSYS_QUYEN
    {
        private const string SP_SYS_QUYEN = "sp_SYS_QUYEN";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarQUYEN_ID;
        private string mvarMAQUYEN;
        private string mvarTENQUYEN;
        private Int32 mvarQUYEN_CHA_ID;
        private string mvarMA_QUYEN_CHA;
        private Boolean mvarENABLE;
        private string mvarDUONGDAN;
        private Int32 mvarSTT;
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

        public Int32 QUYEN_ID
        {
            get { return mvarQUYEN_ID; }
            set { mvarQUYEN_ID = value; }
        }

        public string MAQUYEN
        {
            get { return mvarMAQUYEN; }
            set { mvarMAQUYEN = value; }
        }

        public string TENQUYEN
        {
            get { return mvarTENQUYEN; }
            set { mvarTENQUYEN = value; }
        }

        public Int32 QUYEN_CHA_ID
        {
            get { return mvarQUYEN_CHA_ID; }
            set { mvarQUYEN_CHA_ID = value; }
        }

        public string MA_QUYEN_CHA
        {
            get { return mvarMA_QUYEN_CHA; }
            set { mvarMA_QUYEN_CHA = value; }
        }

        public Boolean ENABLE
        {
            get { return mvarENABLE; }
            set { mvarENABLE = value; }
        }

        public string DUONGDAN
        {
            get { return mvarDUONGDAN; }
            set { mvarDUONGDAN = value; }
        }

        public Int32 STT
        {
            get { return mvarSTT; }
            set { mvarSTT = value; }
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
        public clsSYS_QUYEN()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsSYS_QUYEN(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsSYS_QUYEN(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsSYS_QUYEN(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = SP_SYS_QUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@QUYEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarQUYEN_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@MAQUYEN", DbType.String, clsCommon.GetValueDBNull(mvarMAQUYEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TENQUYEN", DbType.String, clsCommon.GetValueDBNull(mvarTENQUYEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@QUYEN_CHA_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarQUYEN_CHA_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@MA_QUYEN_CHA", DbType.String, clsCommon.GetValueDBNull(mvarMA_QUYEN_CHA), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@ENABLE", DbType.Boolean, clsCommon.GetValueDBNull(mvarENABLE), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@DUONGDAN", DbType.String, clsCommon.GetValueDBNull(mvarDUONGDAN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@STT", DbType.Int32, clsCommon.GetValueDBNull(mvarSTT), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@HOATDONG", DbType.Boolean, clsCommon.GetValueDBNull(mvarHOATDONG), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));

                DAL.ExecNonQuery();

                mvarQUYEN_ID = Int32.Parse(clsCommon.GetValue(DAL.Parameters.Items("@QUYEN_ID").Value, mvarQUYEN_ID.GetType().FullName).ToString());

                return (mvarQUYEN_ID > 0);
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
                DAL.CommandText = SP_SYS_QUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@QUYEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarQUYEN_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@MAQUYEN", DbType.String, clsCommon.GetValueDBNull(mvarMAQUYEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TENQUYEN", DbType.String, clsCommon.GetValueDBNull(mvarTENQUYEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@QUYEN_CHA_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarQUYEN_CHA_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@MA_QUYEN_CHA", DbType.String, clsCommon.GetValueDBNull(mvarMA_QUYEN_CHA), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@ENABLE", DbType.Boolean, clsCommon.GetValueDBNull(mvarENABLE), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@DUONGDAN", DbType.String, clsCommon.GetValueDBNull(mvarDUONGDAN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@STT", DbType.Int32, clsCommon.GetValueDBNull(mvarSTT), ParameterDirection.Input, 4));
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

        public bool Delete(int QUYEN_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_QUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@QUYEN_ID", DbType.Int32, clsCommon.GetValueDBNull(QUYEN_ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_SYS_QUYEN;
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

        public bool GetByKey(int QUYEN_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_QUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@QUYEN_ID", DbType.Int32, clsCommon.GetValueDBNull(QUYEN_ID), ParameterDirection.InputOutput, 4));
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

            mvarQUYEN_ID = Int32.MinValue;
            mvarMAQUYEN = string.Empty;
            mvarTENQUYEN = string.Empty;
            mvarQUYEN_CHA_ID = Int32.MinValue;
            mvarMA_QUYEN_CHA = string.Empty;
            mvarENABLE = false;
            mvarDUONGDAN = string.Empty;
            mvarSTT = Int32.MinValue;
            mvarHOATDONG = false;
            mvarCREATION_DATE = DateTime.MinValue;
            mvarCREATED_BY = Int32.MinValue;
            mvarLAST_UPDATE_DATE = DateTime.MinValue;
            mvarLAST_UPDATED_BY = Int32.MinValue;
        }

        public void FillData(DataRow row)
        {

            mvarQUYEN_ID = Int32.Parse(clsCommon.GetValue(row["QUYEN_ID"], mvarQUYEN_ID.GetType().FullName).ToString());
            mvarMAQUYEN = clsCommon.GetValue(row["MAQUYEN"], mvarMAQUYEN.GetType().FullName).ToString();
            mvarTENQUYEN = clsCommon.GetValue(row["TENQUYEN"], mvarTENQUYEN.GetType().FullName).ToString();
            mvarQUYEN_CHA_ID = Int32.Parse(clsCommon.GetValue(row["QUYEN_CHA_ID"], mvarQUYEN_CHA_ID.GetType().FullName).ToString());
            mvarMA_QUYEN_CHA = clsCommon.GetValue(row["MA_QUYEN_CHA"], mvarMA_QUYEN_CHA.GetType().FullName).ToString();
            mvarENABLE = Boolean.Parse(clsCommon.GetValue(row["ENABLE"], mvarENABLE.GetType().FullName).ToString());
            mvarDUONGDAN = clsCommon.GetValue(row["DUONGDAN"], mvarDUONGDAN.GetType().FullName).ToString();
            mvarSTT = Int32.Parse(clsCommon.GetValue(row["STT"], mvarSTT.GetType().FullName).ToString());
            mvarHOATDONG = Boolean.Parse(clsCommon.GetValue(row["HOATDONG"], mvarHOATDONG.GetType().FullName).ToString());
            mvarCREATION_DATE = DateTime.Parse(clsCommon.GetValue(row["CREATION_DATE"], mvarCREATION_DATE.GetType().FullName).ToString());
            mvarCREATED_BY = Int32.Parse(clsCommon.GetValue(row["CREATED_BY"], mvarCREATED_BY.GetType().FullName).ToString());
            mvarLAST_UPDATE_DATE = DateTime.Parse(clsCommon.GetValue(row["LAST_UPDATE_DATE"], mvarLAST_UPDATE_DATE.GetType().FullName).ToString());
            mvarLAST_UPDATED_BY = Int32.Parse(clsCommon.GetValue(row["LAST_UPDATED_BY"], mvarLAST_UPDATED_BY.GetType().FullName).ToString());
        }

        #endregion	


        #region "Other Methods"	
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        public bool DeleteMenuCha(int QUYEN_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_QUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "DeleteMenuCha", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@QUYEN_ID", DbType.Int32, clsCommon.GetValueDBNull(QUYEN_ID), ParameterDirection.InputOutput, 4));
                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable GetAll_Menu_Cha()
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_QUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetAll_Menu_Cha", ParameterDirection.Input, 50));
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


