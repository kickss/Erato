



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsDM_BIEUTHUE
    {
        private const string SP_DM_BIEUTHUE = "sp_DM_BIEUTHUE";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarBIEUTHUE_ID;
        private string mvarBIEUTHUE_CODE;
        private string mvarBIEUTHUE_NAME;
        private Decimal mvarTYLE_1;
        private Decimal mvarTYLE_2;
        private Decimal mvarTYLE_3;
        private Decimal mvarGIATRI_1;
        private Decimal mvarGIATRI_2;
        private Decimal mvarGIATRI_3;
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

        public Int32 BIEUTHUE_ID
        {
            get { return mvarBIEUTHUE_ID; }
            set { mvarBIEUTHUE_ID = value; }
        }

        public string BIEUTHUE_CODE
        {
            get { return mvarBIEUTHUE_CODE; }
            set { mvarBIEUTHUE_CODE = value; }
        }

        public string BIEUTHUE_NAME
        {
            get { return mvarBIEUTHUE_NAME; }
            set { mvarBIEUTHUE_NAME = value; }
        }

        public Decimal TYLE_1
        {
            get { return mvarTYLE_1; }
            set { mvarTYLE_1 = value; }
        }

        public Decimal TYLE_2
        {
            get { return mvarTYLE_2; }
            set { mvarTYLE_2 = value; }
        }

        public Decimal TYLE_3
        {
            get { return mvarTYLE_3; }
            set { mvarTYLE_3 = value; }
        }

        public Decimal GIATRI_1
        {
            get { return mvarGIATRI_1; }
            set { mvarGIATRI_1 = value; }
        }

        public Decimal GIATRI_2
        {
            get { return mvarGIATRI_2; }
            set { mvarGIATRI_2 = value; }
        }

        public Decimal GIATRI_3
        {
            get { return mvarGIATRI_3; }
            set { mvarGIATRI_3 = value; }
        }

        #endregion


        #region "Constructors"
        public clsDM_BIEUTHUE()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsDM_BIEUTHUE(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsDM_BIEUTHUE(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsDM_BIEUTHUE(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = SP_DM_BIEUTHUE;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@BIEUTHUE_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarBIEUTHUE_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@BIEUTHUE_CODE", DbType.String, clsCommon.GetValueDBNull(mvarBIEUTHUE_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@BIEUTHUE_NAME", DbType.String, clsCommon.GetValueDBNull(mvarBIEUTHUE_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TYLE_1", DbType.Decimal, clsCommon.GetValueDBNull(mvarTYLE_1), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@TYLE_2", DbType.Decimal, clsCommon.GetValueDBNull(mvarTYLE_2), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@TYLE_3", DbType.Decimal, clsCommon.GetValueDBNull(mvarTYLE_3), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@GIATRI_1", DbType.Decimal, clsCommon.GetValueDBNull(mvarGIATRI_1), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@GIATRI_2", DbType.Decimal, clsCommon.GetValueDBNull(mvarGIATRI_2), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@GIATRI_3", DbType.Decimal, clsCommon.GetValueDBNull(mvarGIATRI_3), ParameterDirection.Input, 19));

                DAL.ExecNonQuery();

                mvarBIEUTHUE_ID = Int32.Parse(clsCommon.GetValue(DAL.Parameters.Items("@BIEUTHUE_ID").Value, mvarBIEUTHUE_ID.GetType().FullName).ToString());

                return (mvarBIEUTHUE_ID > 0);
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
                DAL.CommandText = SP_DM_BIEUTHUE;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@BIEUTHUE_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarBIEUTHUE_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@BIEUTHUE_CODE", DbType.String, clsCommon.GetValueDBNull(mvarBIEUTHUE_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@BIEUTHUE_NAME", DbType.String, clsCommon.GetValueDBNull(mvarBIEUTHUE_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TYLE_1", DbType.Decimal, clsCommon.GetValueDBNull(mvarTYLE_1), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@TYLE_2", DbType.Decimal, clsCommon.GetValueDBNull(mvarTYLE_2), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@TYLE_3", DbType.Decimal, clsCommon.GetValueDBNull(mvarTYLE_3), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@GIATRI_1", DbType.Decimal, clsCommon.GetValueDBNull(mvarGIATRI_1), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@GIATRI_2", DbType.Decimal, clsCommon.GetValueDBNull(mvarGIATRI_2), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@GIATRI_3", DbType.Decimal, clsCommon.GetValueDBNull(mvarGIATRI_3), ParameterDirection.Input, 19));

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int BIEUTHUE_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_BIEUTHUE;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@BIEUTHUE_ID", DbType.Int32, clsCommon.GetValueDBNull(BIEUTHUE_ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_DM_BIEUTHUE;
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

        public bool GetByKey(int BIEUTHUE_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_BIEUTHUE;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@BIEUTHUE_ID", DbType.Int32, clsCommon.GetValueDBNull(BIEUTHUE_ID), ParameterDirection.InputOutput, 4));
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

            mvarBIEUTHUE_ID = Int32.MinValue;
            mvarBIEUTHUE_CODE = string.Empty;
            mvarBIEUTHUE_NAME = string.Empty;
            mvarTYLE_1 = Decimal.MinValue;
            mvarTYLE_2 = Decimal.MinValue;
            mvarTYLE_3 = Decimal.MinValue;
            mvarGIATRI_1 = Decimal.MinValue;
            mvarGIATRI_2 = Decimal.MinValue;
            mvarGIATRI_3 = Decimal.MinValue;
        }

        public void FillData(DataRow row)
        {

            mvarBIEUTHUE_ID = Int32.Parse(clsCommon.GetValue(row["BIEUTHUE_ID"], mvarBIEUTHUE_ID.GetType().FullName).ToString());
            mvarBIEUTHUE_CODE = clsCommon.GetValue(row["BIEUTHUE_CODE"], mvarBIEUTHUE_CODE.GetType().FullName).ToString();
            mvarBIEUTHUE_NAME = clsCommon.GetValue(row["BIEUTHUE_NAME"], mvarBIEUTHUE_NAME.GetType().FullName).ToString();
            mvarTYLE_1 = Decimal.Parse(clsCommon.GetValue(row["TYLE_1"], mvarTYLE_1.GetType().FullName).ToString());
            mvarTYLE_2 = Decimal.Parse(clsCommon.GetValue(row["TYLE_2"], mvarTYLE_2.GetType().FullName).ToString());
            mvarTYLE_3 = Decimal.Parse(clsCommon.GetValue(row["TYLE_3"], mvarTYLE_3.GetType().FullName).ToString());
            mvarGIATRI_1 = Decimal.Parse(clsCommon.GetValue(row["GIATRI_1"], mvarGIATRI_1.GetType().FullName).ToString());
            mvarGIATRI_2 = Decimal.Parse(clsCommon.GetValue(row["GIATRI_2"], mvarGIATRI_2.GetType().FullName).ToString());
            mvarGIATRI_3 = Decimal.Parse(clsCommon.GetValue(row["GIATRI_3"], mvarGIATRI_3.GetType().FullName).ToString());
        }

        #endregion


        #region "Other Methods"
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        #endregion

    }
}


