



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsSYS_NHOMNGUOIDUNG_QUYEN
    {
        private const string SP_SYS_NHOMNGUOIDUNG_QUYEN = "sp_SYS_NHOMNGUOIDUNG_QUYEN";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarQUYEN_ID;
        private string mvarQUYEN_CODE;
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

        public Int32 QUYEN_ID
        {
            get { return mvarQUYEN_ID; }
            set { mvarQUYEN_ID = value; }
        }

        public string QUYEN_CODE
        {
            get { return mvarQUYEN_CODE; }
            set { mvarQUYEN_CODE = value; }
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
        public clsSYS_NHOMNGUOIDUNG_QUYEN()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsSYS_NHOMNGUOIDUNG_QUYEN(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsSYS_NHOMNGUOIDUNG_QUYEN(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsSYS_NHOMNGUOIDUNG_QUYEN(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = SP_SYS_NHOMNGUOIDUNG_QUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@QUYEN_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarQUYEN_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@QUYEN_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarQUYEN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarNHOMNGUOIDUNG_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarNHOMNGUOIDUNG_CODE), ParameterDirection.Input, 1000));

                DAL.ExecNonQuery();

                mvarQUYEN_ID = Int32.Parse(UTILITIES.clsCommon.GetValue(DAL.Parameters.Items("@QUYEN_ID").Value, mvarQUYEN_ID.GetType().FullName).ToString());

                return (mvarQUYEN_ID > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateByNhomNguoiDung(int NhomNguoiDung_Id, int Quyen_Id, string Quyen_Code)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_NHOMNGUOIDUNG_QUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "UpdateByNhomNguoiDung", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@QUYEN_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(Quyen_Id), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@QUYEN_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(Quyen_Code), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(NhomNguoiDung_Id), ParameterDirection.InputOutput, 4));
                

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateByQuyen(int Quyen_Id,int NhomNguoiDung_Id,string NhomNguoiDung_Code)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_NHOMNGUOIDUNG_QUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "UpdateByQuyen", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@QUYEN_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(Quyen_Id), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(NhomNguoiDung_Id), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_CODE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(NhomNguoiDung_Code), ParameterDirection.Input, 1000));

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeleteByNhomNguoiDung(int NhomNguoiDung_Id)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_NHOMNGUOIDUNG_QUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(NhomNguoiDung_Id), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_SYS_NHOMNGUOIDUNG_QUYEN;
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

        public bool GetByQuyen_Id(int QUYEN_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_NHOMNGUOIDUNG_QUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByQuyen_Id", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@QUYEN_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(QUYEN_ID), ParameterDirection.InputOutput, 4)); DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(NHOMNGUOIDUNG_ID), ParameterDirection.InputOutput, 4));
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

        public bool GetByNhomNguoiDung_Id(int intNhomNguoiDung_Id)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_NHOMNGUOIDUNG_QUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByNhomNguoiDung_Id", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(intNhomNguoiDung_Id), ParameterDirection.InputOutput, 4));
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
            mvarQUYEN_CODE = string.Empty;
            mvarNHOMNGUOIDUNG_ID = Int32.MinValue;
            mvarNHOMNGUOIDUNG_CODE = string.Empty;
        }

        public void FillData(DataRow row)
        {

            mvarQUYEN_ID = Int32.Parse(UTILITIES.clsCommon.GetValue(row["QUYEN_ID"], mvarQUYEN_ID.GetType().FullName).ToString());
            mvarQUYEN_CODE = UTILITIES.clsCommon.GetValue(row["QUYEN_CODE"], mvarQUYEN_CODE.GetType().FullName).ToString();
            mvarNHOMNGUOIDUNG_ID = Int32.Parse(UTILITIES.clsCommon.GetValue(row["NHOMNGUOIDUNG_ID"], mvarNHOMNGUOIDUNG_ID.GetType().FullName).ToString());
            mvarNHOMNGUOIDUNG_CODE = UTILITIES.clsCommon.GetValue(row["NHOMNGUOIDUNG_CODE"], mvarNHOMNGUOIDUNG_CODE.GetType().FullName).ToString();
        }

        #endregion

        #region "Other Methods"
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        public bool DeleteQuyenByNhomNguoiDung(int intNhomNguoiDung)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_SYS_NHOMNGUOIDUNG_QUYEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "DeleteQuyenByNhomNguoiDung", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(intNhomNguoiDung), ParameterDirection.InputOutput, 4));
                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion	

    }
}


