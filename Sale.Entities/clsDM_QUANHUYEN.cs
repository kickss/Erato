using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsDM_QUANHUYEN
    {
        private const string SP_DM_QUANHUYEN = "sp_DM_QUANHUYEN";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarQUANHUYEN_ID;
        private string mvarQUANHUYEN_NAME;
        private string mvarQUANHUYEN_TYPE;
        private string mvarTINHTHANH_ID;
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

        public Int32 QUANHUYEN_ID
        {
            get { return mvarQUANHUYEN_ID; }
            set { mvarQUANHUYEN_ID = value; }
        }

        public string QUANHUYEN_NAME
        {
            get { return mvarQUANHUYEN_NAME; }
            set { mvarQUANHUYEN_NAME = value; }
        }

        public string QUANHUYEN_TYPE
        {
            get { return mvarQUANHUYEN_TYPE; }
            set { mvarQUANHUYEN_TYPE = value; }
        }

        public string TINHTHANH_ID
        {
            get { return mvarTINHTHANH_ID; }
            set { mvarTINHTHANH_ID = value; }
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

        public bool Add()
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_QUANHUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@QUANHUYEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarQUANHUYEN_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@QUANHUYEN_NAME", DbType.String, clsCommon.GetValueDBNull(mvarQUANHUYEN_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@QUANHUYEN_TYPE", DbType.String, clsCommon.GetValueDBNull(mvarQUANHUYEN_TYPE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TINHTHANH_ID", DbType.String, clsCommon.GetValueDBNull(mvarTINHTHANH_ID), ParameterDirection.Input, 1000));

                DAL.ExecNonQuery();

                mvarQUANHUYEN_ID = Int32.Parse(clsCommon.GetValue(DAL.Parameters.Items("@QUANHUYEN_ID").Value, mvarQUANHUYEN_ID.GetType().FullName).ToString());

                return (mvarQUANHUYEN_ID > 0);
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
                DAL.CommandText = SP_DM_QUANHUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@QUANHUYEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarQUANHUYEN_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@QUANHUYEN_NAME", DbType.String, clsCommon.GetValueDBNull(mvarQUANHUYEN_NAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@QUANHUYEN_TYPE", DbType.String, clsCommon.GetValueDBNull(mvarQUANHUYEN_TYPE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TINHTHANH_ID", DbType.String, clsCommon.GetValueDBNull(mvarTINHTHANH_ID), ParameterDirection.Input, 1000));

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int QUANHUYEN_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_QUANHUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@QUANHUYEN_ID", DbType.Int32, clsCommon.GetValueDBNull(QUANHUYEN_ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_DM_QUANHUYEN;
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

        public bool GetByKey(int QUANHUYEN_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_QUANHUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@QUANHUYEN_ID", DbType.Int32, clsCommon.GetValueDBNull(QUANHUYEN_ID), ParameterDirection.InputOutput, 4));
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

            mvarQUANHUYEN_ID = Int32.MinValue;
            mvarQUANHUYEN_NAME = string.Empty;
            mvarQUANHUYEN_TYPE = string.Empty;
            mvarTINHTHANH_ID = string.Empty;
        }

        public void FillData(DataRow row)
        {

            mvarQUANHUYEN_ID = Int32.Parse(clsCommon.GetValue(row["QUANHUYEN_ID"], mvarQUANHUYEN_ID.GetType().FullName).ToString());
            mvarQUANHUYEN_NAME = clsCommon.GetValue(row["QUANHUYEN_NAME"], mvarQUANHUYEN_NAME.GetType().FullName).ToString();
            mvarQUANHUYEN_TYPE = clsCommon.GetValue(row["QUANHUYEN_TYPE"], mvarQUANHUYEN_TYPE.GetType().FullName).ToString();
            mvarTINHTHANH_ID = clsCommon.GetValue(row["TINHTHANH_ID"], mvarTINHTHANH_ID.GetType().FullName).ToString();
        }

        #endregion

        #region "Other Methods"
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        public DataTable GetQuanHuyenByTinhThanh(string strTinhThanh_Id)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_QUANHUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetQuanHuyenByTinhThanh", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@TINHTHANH_ID", DbType.String, clsCommon.GetValueDBNull(strTinhThanh_Id), ParameterDirection.Input, 1000));
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