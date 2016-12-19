



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsDM_QUANHUYEN
    {
        private const string sp_DM_QUANHUYEN = "sp_DM_QUANHUYEN";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"	

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private string mvarDISTRICT_ID;
        private string mvarDISTRICT_NAME;
        private string mvarDISTRICT_TYPE;
        private string mvarPROVINCE_ID;
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

        public string DISTRICT_ID
        {
            get { return mvarDISTRICT_ID; }
            set { mvarDISTRICT_ID = value; }
        }

        public string DISTRICT_NAME
        {
            get { return mvarDISTRICT_NAME; }
            set { mvarDISTRICT_NAME = value; }
        }

        public string DISTRICT_TYPE
        {
            get { return mvarDISTRICT_TYPE; }
            set { mvarDISTRICT_TYPE = value; }
        }

        public string PROVINCE_ID
        {
            get { return mvarPROVINCE_ID; }
            set { mvarPROVINCE_ID = value; }
        }

        #endregion

        #region "Constructors"
        public clsDM_QUANHUYEN()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsDM_QUANHUYEN(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsDM_QUANHUYEN(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsDM_QUANHUYEN(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = sp_DM_QUANHUYEN;
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

        public DataTable Get_District_By_Province(string PROVINCE_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = sp_DM_QUANHUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Get_District_By_Province", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@PROVINCE_ID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(PROVINCE_ID), ParameterDirection.InputOutput, 1000));

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

            mvarDISTRICT_ID = string.Empty;
            mvarDISTRICT_NAME = string.Empty;
            mvarDISTRICT_TYPE = string.Empty;
            mvarPROVINCE_ID = string.Empty;
        }

        public void FillData(DataRow row)
        {

            mvarDISTRICT_ID = UTILITIES.clsCommon.GetValue(row["DISTRICT_ID"], mvarDISTRICT_ID.GetType().FullName).ToString();
            mvarDISTRICT_NAME = UTILITIES.clsCommon.GetValue(row["DISTRICT_NAME"], mvarDISTRICT_NAME.GetType().FullName).ToString();
            mvarDISTRICT_TYPE = UTILITIES.clsCommon.GetValue(row["DISTRICT_TYPE"], mvarDISTRICT_TYPE.GetType().FullName).ToString();
            mvarPROVINCE_ID = UTILITIES.clsCommon.GetValue(row["PROVINCE_ID"], mvarPROVINCE_ID.GetType().FullName).ToString();
        }

        #endregion

        #region "Other Methods"	
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        #endregion

    }
}


