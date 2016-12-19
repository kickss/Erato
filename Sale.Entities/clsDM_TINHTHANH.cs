



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsDM_TINHTHANH
    {
        private const string sp_DM_TINHTHANH = "sp_DM_TINHTHANH";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"	

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private string mvarPROVINCE_ID;
        private string mvarPROVINCE_NAME;
        private string mvarPROVINCE_TYPE;
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

        public string PROVINCE_ID
        {
            get { return mvarPROVINCE_ID; }
            set { mvarPROVINCE_ID = value; }
        }

        public string PROVINCE_NAME
        {
            get { return mvarPROVINCE_NAME; }
            set { mvarPROVINCE_NAME = value; }
        }

        public string PROVINCE_TYPE
        {
            get { return mvarPROVINCE_TYPE; }
            set { mvarPROVINCE_TYPE = value; }
        }

        #endregion

        #region "Constructors"
        public clsDM_TINHTHANH()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsDM_TINHTHANH(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsDM_TINHTHANH(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsDM_TINHTHANH(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = sp_DM_TINHTHANH;
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

        public void Reset()
        {
            mvarLANGUAGEID = string.Empty;
            mvarUSERID = Int32.MinValue;
            mvarFREEPARA = string.Empty;

            mvarPROVINCE_ID = string.Empty;
            mvarPROVINCE_NAME = string.Empty;
            mvarPROVINCE_TYPE = string.Empty;
        }

        public void FillData(DataRow row)
        {

            mvarPROVINCE_ID = UTILITIES.clsCommon.GetValue(row["PROVINCE_ID"], mvarPROVINCE_ID.GetType().FullName).ToString();
            mvarPROVINCE_NAME = UTILITIES.clsCommon.GetValue(row["PROVINCE_NAME"], mvarPROVINCE_NAME.GetType().FullName).ToString();
            mvarPROVINCE_TYPE = UTILITIES.clsCommon.GetValue(row["PROVINCE_TYPE"], mvarPROVINCE_TYPE.GetType().FullName).ToString();
        }

        #endregion

        #region "Other Methods"	
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        #endregion

    }
}


