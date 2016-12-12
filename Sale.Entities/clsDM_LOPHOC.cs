



using System;
using System.Data;

using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsDM_LOPHOC
    {
        private const string SP_DM_LOPHOC = "sp_DM_LOPHOC";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarLOPHOC_ID;
        private string mvarMALOP;
        private string mvarTENLOP;
        private Int32 mvarLOAI_LOPHOC;
        private string mvarLOAI_LOPHOC_CODE;
        private Int32 mvarGIANGVIEN_ID;
        private string mvarGIANGVIEN_CODE;
        private Int32 mvarGIANGVIEN_PHU_ID;
        private string mvarGIANGVIEN__PHU_CODE;
        private DateTime mvarCREATION_DATE;
        private Int32 mvarCREATED_BY;
        private DateTime mvarLAST_UPDATE_DATE;
        private Int32 mvarLAST_UPDATED_BY;
        private Decimal mvarDONGIA;
        private Decimal mvarDONGIA_UT;
        private DateTime mvarSTART_DATE;
        private DateTime mvarEND_DATE;
        private Int32 mvarTHOILUONG_MH;
        private Int32 mvarSOLUONG_DK;
        private Boolean mvarKET_THUC_DK;
        private Boolean mvarKET_THUC_HOC;
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

        public Int32 LOPHOC_ID
        {
            get { return mvarLOPHOC_ID; }
            set { mvarLOPHOC_ID = value; }
        }

        public string MALOP
        {
            get { return mvarMALOP; }
            set { mvarMALOP = value; }
        }

        public string TENLOP
        {
            get { return mvarTENLOP; }
            set { mvarTENLOP = value; }
        }

        public Int32 LOAI_LOPHOC
        {
            get { return mvarLOAI_LOPHOC; }
            set { mvarLOAI_LOPHOC = value; }
        }

        public string LOAI_LOPHOC_CODE
        {
            get { return mvarLOAI_LOPHOC_CODE; }
            set { mvarLOAI_LOPHOC_CODE = value; }
        }

        public Int32 GIANGVIEN_ID
        {
            get { return mvarGIANGVIEN_ID; }
            set { mvarGIANGVIEN_ID = value; }
        }

        public string GIANGVIEN_CODE
        {
            get { return mvarGIANGVIEN_CODE; }
            set { mvarGIANGVIEN_CODE = value; }
        }

        public Int32 GIANGVIEN_PHU_ID
        {
            get { return mvarGIANGVIEN_PHU_ID; }
            set { mvarGIANGVIEN_PHU_ID = value; }
        }

        public string GIANGVIEN__PHU_CODE
        {
            get { return mvarGIANGVIEN__PHU_CODE; }
            set { mvarGIANGVIEN__PHU_CODE = value; }
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

        public Decimal DONGIA
        {
            get { return mvarDONGIA; }
            set { mvarDONGIA = value; }
        }

        public Decimal DONGIA_UT
        {
            get { return mvarDONGIA_UT; }
            set { mvarDONGIA_UT = value; }
        }

        public DateTime START_DATE
        {
            get { return mvarSTART_DATE; }
            set { mvarSTART_DATE = value; }
        }

        public DateTime END_DATE
        {
            get { return mvarEND_DATE; }
            set { mvarEND_DATE = value; }
        }

        public Int32 THOILUONG_MH
        {
            get { return mvarTHOILUONG_MH; }
            set { mvarTHOILUONG_MH = value; }
        }

        public Int32 SOLUONG_DK
        {
            get { return mvarSOLUONG_DK; }
            set { mvarSOLUONG_DK = value; }
        }

        public Boolean KET_THUC_DK
        {
            get { return mvarKET_THUC_DK; }
            set { mvarKET_THUC_DK = value; }
        }

        public Boolean KET_THUC_HOC
        {
            get { return mvarKET_THUC_HOC; }
            set { mvarKET_THUC_HOC = value; }
        }

        #endregion


        #region "Constructors"
        public clsDM_LOPHOC()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsDM_LOPHOC(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsDM_LOPHOC(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsDM_LOPHOC(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = SP_DM_LOPHOC;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@LOPHOC_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOPHOC_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@MALOP", DbType.String, clsCommon.GetValueDBNull(mvarMALOP), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TENLOP", DbType.String, clsCommon.GetValueDBNull(mvarTENLOP), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@LOAI_LOPHOC", DbType.Int32, clsCommon.GetValueDBNull(mvarLOAI_LOPHOC), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOAI_LOPHOC_CODE", DbType.String, clsCommon.GetValueDBNull(mvarLOAI_LOPHOC_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarGIANGVIEN_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN_CODE", DbType.String, clsCommon.GetValueDBNull(mvarGIANGVIEN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN_PHU_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarGIANGVIEN_PHU_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN__PHU_CODE", DbType.String, clsCommon.GetValueDBNull(mvarGIANGVIEN__PHU_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@DONGIA", DbType.Decimal, clsCommon.GetValueDBNull(mvarDONGIA), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@DONGIA_UT", DbType.Decimal, clsCommon.GetValueDBNull(mvarDONGIA_UT), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@START_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarSTART_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@END_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarEND_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@THOILUONG_MH", DbType.Int32, clsCommon.GetValueDBNull(mvarTHOILUONG_MH), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@SOLUONG_DK", DbType.Int32, clsCommon.GetValueDBNull(mvarSOLUONG_DK), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@KET_THUC_DK", DbType.Boolean, clsCommon.GetValueDBNull(mvarKET_THUC_DK), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@KET_THUC_HOC", DbType.Boolean, clsCommon.GetValueDBNull(mvarKET_THUC_HOC), ParameterDirection.Input, 2));

                DAL.ExecNonQuery();

                mvarLOPHOC_ID = Int32.Parse(clsCommon.GetValue(DAL.Parameters.Items("@LOPHOC_ID").Value, mvarLOPHOC_ID.GetType().FullName).ToString());

                return (mvarLOPHOC_ID > 0);
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
                DAL.CommandText = SP_DM_LOPHOC;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@LOPHOC_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarLOPHOC_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@MALOP", DbType.String, clsCommon.GetValueDBNull(mvarMALOP), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TENLOP", DbType.String, clsCommon.GetValueDBNull(mvarTENLOP), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@LOAI_LOPHOC", DbType.Int32, clsCommon.GetValueDBNull(mvarLOAI_LOPHOC), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LOAI_LOPHOC_CODE", DbType.String, clsCommon.GetValueDBNull(mvarLOAI_LOPHOC_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarGIANGVIEN_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN_CODE", DbType.String, clsCommon.GetValueDBNull(mvarGIANGVIEN_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN_PHU_ID", DbType.Int32, clsCommon.GetValueDBNull(mvarGIANGVIEN_PHU_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@GIANGVIEN__PHU_CODE", DbType.String, clsCommon.GetValueDBNull(mvarGIANGVIEN__PHU_CODE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@DONGIA", DbType.Decimal, clsCommon.GetValueDBNull(mvarDONGIA), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@DONGIA_UT", DbType.Decimal, clsCommon.GetValueDBNull(mvarDONGIA_UT), ParameterDirection.Input, 19));
                DAL.Parameters.Add(new ParamStruct("@START_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarSTART_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@END_DATE", DbType.DateTime, clsCommon.GetValueDBNull(mvarEND_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@THOILUONG_MH", DbType.Int32, clsCommon.GetValueDBNull(mvarTHOILUONG_MH), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@SOLUONG_DK", DbType.Int32, clsCommon.GetValueDBNull(mvarSOLUONG_DK), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@KET_THUC_DK", DbType.Boolean, clsCommon.GetValueDBNull(mvarKET_THUC_DK), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@KET_THUC_HOC", DbType.Boolean, clsCommon.GetValueDBNull(mvarKET_THUC_HOC), ParameterDirection.Input, 2));

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int LOPHOC_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_LOPHOC;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@LOPHOC_ID", DbType.Int32, clsCommon.GetValueDBNull(LOPHOC_ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_DM_LOPHOC;
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

        public bool GetByKey(int LOPHOC_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_LOPHOC;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@LOPHOC_ID", DbType.Int32, clsCommon.GetValueDBNull(LOPHOC_ID), ParameterDirection.InputOutput, 4));
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

            mvarLOPHOC_ID = Int32.MinValue;
            mvarMALOP = string.Empty;
            mvarTENLOP = string.Empty;
            mvarLOAI_LOPHOC = Int32.MinValue;
            mvarLOAI_LOPHOC_CODE = string.Empty;
            mvarGIANGVIEN_ID = Int32.MinValue;
            mvarGIANGVIEN_CODE = string.Empty;
            mvarGIANGVIEN_PHU_ID = Int32.MinValue;
            mvarGIANGVIEN__PHU_CODE = string.Empty;
            mvarCREATION_DATE = DateTime.MinValue;
            mvarCREATED_BY = Int32.MinValue;
            mvarLAST_UPDATE_DATE = DateTime.MinValue;
            mvarLAST_UPDATED_BY = Int32.MinValue;
            mvarDONGIA = Decimal.MinValue;
            mvarDONGIA_UT = Decimal.MinValue;
            mvarSTART_DATE = DateTime.MinValue;
            mvarEND_DATE = DateTime.MinValue;
            mvarTHOILUONG_MH = Int32.MinValue;
            mvarSOLUONG_DK = Int32.MinValue;
            mvarKET_THUC_DK = false;
            mvarKET_THUC_HOC = false;
        }

        public void FillData(DataRow row)
        {

            mvarLOPHOC_ID = Int32.Parse(clsCommon.GetValue(row["LOPHOC_ID"], mvarLOPHOC_ID.GetType().FullName).ToString());
            mvarMALOP = clsCommon.GetValue(row["MALOP"], mvarMALOP.GetType().FullName).ToString();
            mvarTENLOP = clsCommon.GetValue(row["TENLOP"], mvarTENLOP.GetType().FullName).ToString();
            mvarLOAI_LOPHOC = Int32.Parse(clsCommon.GetValue(row["LOAI_LOPHOC"], mvarLOAI_LOPHOC.GetType().FullName).ToString());
            mvarLOAI_LOPHOC_CODE = clsCommon.GetValue(row["LOAI_LOPHOC_CODE"], mvarLOAI_LOPHOC_CODE.GetType().FullName).ToString();
            mvarGIANGVIEN_ID = Int32.Parse(clsCommon.GetValue(row["GIANGVIEN_ID"], mvarGIANGVIEN_ID.GetType().FullName).ToString());
            mvarGIANGVIEN_CODE = clsCommon.GetValue(row["GIANGVIEN_CODE"], mvarGIANGVIEN_CODE.GetType().FullName).ToString();
            mvarGIANGVIEN_PHU_ID = Int32.Parse(clsCommon.GetValue(row["GIANGVIEN_PHU_ID"], mvarGIANGVIEN_PHU_ID.GetType().FullName).ToString());
            mvarGIANGVIEN__PHU_CODE = clsCommon.GetValue(row["GIANGVIEN__PHU_CODE"], mvarGIANGVIEN__PHU_CODE.GetType().FullName).ToString();
            mvarCREATION_DATE = DateTime.Parse(clsCommon.GetValue(row["CREATION_DATE"], mvarCREATION_DATE.GetType().FullName).ToString());
            mvarCREATED_BY = Int32.Parse(clsCommon.GetValue(row["CREATED_BY"], mvarCREATED_BY.GetType().FullName).ToString());
            mvarLAST_UPDATE_DATE = DateTime.Parse(clsCommon.GetValue(row["LAST_UPDATE_DATE"], mvarLAST_UPDATE_DATE.GetType().FullName).ToString());
            mvarLAST_UPDATED_BY = Int32.Parse(clsCommon.GetValue(row["LAST_UPDATED_BY"], mvarLAST_UPDATED_BY.GetType().FullName).ToString());
            mvarDONGIA = Decimal.Parse(clsCommon.GetValue(row["DONGIA"], mvarDONGIA.GetType().FullName).ToString());
            mvarDONGIA_UT = Decimal.Parse(clsCommon.GetValue(row["DONGIA_UT"], mvarDONGIA_UT.GetType().FullName).ToString());
            mvarSTART_DATE = DateTime.Parse(clsCommon.GetValue(row["START_DATE"], mvarSTART_DATE.GetType().FullName).ToString());
            mvarEND_DATE = DateTime.Parse(clsCommon.GetValue(row["END_DATE"], mvarEND_DATE.GetType().FullName).ToString());
            mvarTHOILUONG_MH = Int32.Parse(clsCommon.GetValue(row["THOILUONG_MH"], mvarTHOILUONG_MH.GetType().FullName).ToString());
            mvarSOLUONG_DK = Int32.Parse(clsCommon.GetValue(row["SOLUONG_DK"], mvarSOLUONG_DK.GetType().FullName).ToString());
            mvarKET_THUC_DK = Boolean.Parse(clsCommon.GetValue(row["KET_THUC_DK"], mvarKET_THUC_DK.GetType().FullName).ToString());
            mvarKET_THUC_HOC = Boolean.Parse(clsCommon.GetValue(row["KET_THUC_HOC"], mvarKET_THUC_HOC.GetType().FullName).ToString());
        }

        #endregion


        #region "Other Methods"
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        #endregion

    }
}


