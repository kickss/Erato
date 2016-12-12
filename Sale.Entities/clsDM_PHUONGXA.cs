



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsDM_PHUONGXA
    {
        private const string SP_DM_PHUONGXA = "sp_DM_PHUONGXA";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarPHUONGXA_ID;
        private string mvarPHUONGXA_NAME;
        private string mvarPHUONGXA_TYPE;
        private string mvarQUANHHUYEN_ID;
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

        public Int32 PHUONGXA_ID
        {
            get { return mvarPHUONGXA_ID; }
            set { mvarPHUONGXA_ID = value; }
        }

        public string PHUONGXA_NAME
        {
            get { return mvarPHUONGXA_NAME; }
            set { mvarPHUONGXA_NAME = value; }
        }

        public string PHUONGXA_TYPE
        {
            get { return mvarPHUONGXA_TYPE; }
            set { mvarPHUONGXA_TYPE = value; }
        }

        public string QUANHHUYEN_ID
        {
            get { return mvarQUANHHUYEN_ID; }
            set { mvarQUANHHUYEN_ID = value; }
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

        public bool Add()
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_PHUONGXA;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@PHUONGXA_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarPHUONGXA_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@PHUONGXA_NAME", DbType.String, clsCommon.GetValueDBNull(mvarPHUONGXA_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@PHUONGXA_TYPE", DbType.String, clsCommon.GetValueDBNull(mvarPHUONGXA_TYPE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@QUANHHUYEN_ID", DbType.String, clsCommon.GetValueDBNull(mvarQUANHHUYEN_ID), ParameterDirection.Input, 1000));

                DAL.ExecNonQuery();

                mvarPHUONGXA_ID = Int32.Parse(clsCommon.GetValue(DAL.Parameters.Items("@PHUONGXA_ID").Value, mvarPHUONGXA_ID.GetType().FullName).ToString());

                return (mvarPHUONGXA_ID > 0);
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
                DAL.CommandText = SP_DM_PHUONGXA;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@PHUONGXA_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarPHUONGXA_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@PHUONGXA_NAME", DbType.String, clsCommon.GetValueDBNull(mvarPHUONGXA_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@PHUONGXA_TYPE", DbType.String, clsCommon.GetValueDBNull(mvarPHUONGXA_TYPE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@QUANHHUYEN_ID", DbType.String, clsCommon.GetValueDBNull(mvarQUANHHUYEN_ID), ParameterDirection.Input, 1000));

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int PHUONGXA_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_PHUONGXA;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@PHUONGXA_ID", DbType.Int32, clsCommon.GetValueDBNull(PHUONGXA_ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_DM_PHUONGXA;
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

        public bool GetByKey(int PHUONGXA_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_PHUONGXA;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@PHUONGXA_ID", DbType.Int32, clsCommon.GetValueDBNull(PHUONGXA_ID), ParameterDirection.InputOutput, 4));
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

            mvarPHUONGXA_ID = Int32.MinValue;
            mvarPHUONGXA_NAME = string.Empty;
            mvarPHUONGXA_TYPE = string.Empty;
            mvarQUANHHUYEN_ID = string.Empty;
        }

        public void FillData(DataRow row)
        {

            mvarPHUONGXA_ID = Int32.Parse(clsCommon.GetValue(row["PHUONGXA_ID"], mvarPHUONGXA_ID.GetType().FullName).ToString());
            mvarPHUONGXA_NAME = clsCommon.GetValue(row["PHUONGXA_NAME"], mvarPHUONGXA_NAME.GetType().FullName).ToString();
            mvarPHUONGXA_TYPE = clsCommon.GetValue(row["PHUONGXA_TYPE"], mvarPHUONGXA_TYPE.GetType().FullName).ToString();
            mvarQUANHHUYEN_ID = clsCommon.GetValue(row["QUANHHUYEN_ID"], mvarQUANHHUYEN_ID.GetType().FullName).ToString();
        }

        #endregion


        #region "Other Methods"
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        public DataTable GetPhuongXaByQuanHuyen(string strQuanHuyen_Id)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_PHUONGXA;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetPhuongXaByQuanHuyen", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@QUANHHUYEN_ID", DbType.String, clsCommon.GetValueDBNull(strQuanHuyen_Id), ParameterDirection.Input, 1000));
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


