



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsDM_PHUONGXA
    {
        private const string sp_DM_PHUONGXA = "sp_DM_PHUONGXA";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"	

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private string mvarWARD_ID;
        private string mvarWARD_NAME;
        private string mvarWARD_TYPE;
        private string mvarDISTRICT_ID;
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

        public string WARD_ID
        {
            get { return mvarWARD_ID; }
            set { mvarWARD_ID = value; }
        }

        public string WARD_NAME
        {
            get { return mvarWARD_NAME; }
            set { mvarWARD_NAME = value; }
        }

        public string WARD_TYPE
        {
            get { return mvarWARD_TYPE; }
            set { mvarWARD_TYPE = value; }
        }

        public string DISTRICT_ID
        {
            get { return mvarDISTRICT_ID; }
            set { mvarDISTRICT_ID = value; }
        }

        #endregion

        #region "Constructors"
        public clsDM_PHUONGXA()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsDM_PHUONGXA(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsDM_PHUONGXA(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsDM_PHUONGXA(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = mdal;
        }

        #endregion

        #region "Methods"
        public DataTable GetAll()
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = sp_DM_PHUONGXA;
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

        public DataTable Get_Ward_By_District(string DISTRICT_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = sp_DM_PHUONGXA;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Get_Ward_By_District", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@DISTRICT_ID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(DISTRICT_ID), ParameterDirection.InputOutput, 1000));

                ds = DAL.ExecDataSet();
                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Reset()
        {
            mvarLANGUAGEID = string.Empty;
            mvarUSERID = Int32.MinValue;
            mvarFREEPARA = string.Empty;

            mvarWARD_ID = string.Empty;
            mvarWARD_NAME = string.Empty;
            mvarWARD_TYPE = string.Empty;
            mvarDISTRICT_ID = string.Empty;
        }

        public void FillData(DataRow row)
        {

            mvarWARD_ID = UTILITIES.clsCommon.GetValue(row["WARD_ID"], mvarWARD_ID.GetType().FullName).ToString();
            mvarWARD_NAME = UTILITIES.clsCommon.GetValue(row["WARD_NAME"], mvarWARD_NAME.GetType().FullName).ToString();
            mvarWARD_TYPE = UTILITIES.clsCommon.GetValue(row["WARD_TYPE"], mvarWARD_TYPE.GetType().FullName).ToString();
            mvarDISTRICT_ID = UTILITIES.clsCommon.GetValue(row["DISTRICT_ID"], mvarDISTRICT_ID.GetType().FullName).ToString();
        }

        #endregion

        #region "Other Methods"	
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        #endregion

    }
}


