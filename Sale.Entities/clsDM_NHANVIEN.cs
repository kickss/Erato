



using System;
using System.Data;
using Sale.DAL;
using Sale.UTILITIES;

namespace Sale.Entities
{
    public class clsDM_NHANVIEN
    {
        private const string SP_DM_NHANVIEN = "sp_DM_NHANVIEN";
        private DataAccess m_DAL = new DataAccess();

        #region "Variables"

        private string mvarLANGUAGEID;
        private Int32 mvarUSERID;
        private string mvarFREEPARA;

        private Int32 mvarNHANVIEN_ID;
        private Int32 mvarNHOMNGUOIDUNG_ID;
        private Int32 mvarCHUCVU_ID;
        private Int32 mvarPHONGBAN_ID;
        private string mvarMANHANVIEN;
        private string mvarHO_NHANVIEN;
        private string mvarEMAIL_NHANVIEN;
        private Boolean mvarGIOITINH;
        private string mvarDIACHI_TAMTRU;
        private string mvarUSERNAME;
        private string mvarPW;
        private Boolean mvarISLOGIN;
        private DateTime mvarLOGIN_TIME;
        private DateTime mvarLAST_LOGOUT_TIME;
        private DateTime mvarCREATION_DATE;
        private Int32 mvarCREATED_BY;
        private DateTime mvarLAST_UPDATE_DATE;
        private Int32 mvarLAST_UPDATED_BY;
        private string mvarCMND_SO;
        private string mvarCMND_NOICAP;
        private Int32 mvarDANTOC;
        private Int32 mvarTONGIAO;
        private Int32 mvarDIENTHOAI_NHA;
        private Int32 mvarDIENTHOAI_DIDONG;
        private string mvarDIACHI_THUONGTRU;
        private Int32 mvarTRANGTHAI_LAMVIEC;
        private string mvarTRINHDO_VANHOA;
        private string mvarNOISINH;
        private string mvarQUEQUAN;
        private string mvarMASOTHUE;
        private DateTime mvarNGAYVAOLAM;
        private DateTime mvarNGAYSINH;
        private string mvarTEN_NHANVIEN;
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

        public Int32 NHANVIEN_ID
        {
            get { return mvarNHANVIEN_ID; }
            set { mvarNHANVIEN_ID = value; }
        }

        public Int32 NHOMNGUOIDUNG_ID
        {
            get { return mvarNHOMNGUOIDUNG_ID; }
            set { mvarNHOMNGUOIDUNG_ID = value; }
        }

        public Int32 CHUCVU_ID
        {
            get { return mvarCHUCVU_ID; }
            set { mvarCHUCVU_ID = value; }
        }

        public Int32 PHONGBAN_ID
        {
            get { return mvarPHONGBAN_ID; }
            set { mvarPHONGBAN_ID = value; }
        }

        public string MANHANVIEN
        {
            get { return mvarMANHANVIEN; }
            set { mvarMANHANVIEN = value; }
        }

        public string HO_NHANVIEN
        {
            get { return mvarHO_NHANVIEN; }
            set { mvarHO_NHANVIEN = value; }
        }

        public string EMAIL_NHANVIEN
        {
            get { return mvarEMAIL_NHANVIEN; }
            set { mvarEMAIL_NHANVIEN = value; }
        }

        public Boolean GIOITINH
        {
            get { return mvarGIOITINH; }
            set { mvarGIOITINH = value; }
        }

        public string DIACHI_TAMTRU
        {
            get { return mvarDIACHI_TAMTRU; }
            set { mvarDIACHI_TAMTRU = value; }
        }

        public string USERNAME
        {
            get { return mvarUSERNAME; }
            set { mvarUSERNAME = value; }
        }

        public string PW
        {
            get { return mvarPW; }
            set { mvarPW = value; }
        }

        public Boolean ISLOGIN
        {
            get { return mvarISLOGIN; }
            set { mvarISLOGIN = value; }
        }

        public DateTime LOGIN_TIME
        {
            get { return mvarLOGIN_TIME; }
            set { mvarLOGIN_TIME = value; }
        }

        public DateTime LAST_LOGOUT_TIME
        {
            get { return mvarLAST_LOGOUT_TIME; }
            set { mvarLAST_LOGOUT_TIME = value; }
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

        public string CMND_SO
        {
            get { return mvarCMND_SO; }
            set { mvarCMND_SO = value; }
        }

        public string CMND_NOICAP
        {
            get { return mvarCMND_NOICAP; }
            set { mvarCMND_NOICAP = value; }
        }

        public Int32 DANTOC
        {
            get { return mvarDANTOC; }
            set { mvarDANTOC = value; }
        }

        public Int32 TONGIAO
        {
            get { return mvarTONGIAO; }
            set { mvarTONGIAO = value; }
        }

        public Int32 DIENTHOAI_NHA
        {
            get { return mvarDIENTHOAI_NHA; }
            set { mvarDIENTHOAI_NHA = value; }
        }

        public Int32 DIENTHOAI_DIDONG
        {
            get { return mvarDIENTHOAI_DIDONG; }
            set { mvarDIENTHOAI_DIDONG = value; }
        }

        public string DIACHI_THUONGTRU
        {
            get { return mvarDIACHI_THUONGTRU; }
            set { mvarDIACHI_THUONGTRU = value; }
        }

        public Int32 TRANGTHAI_LAMVIEC
        {
            get { return mvarTRANGTHAI_LAMVIEC; }
            set { mvarTRANGTHAI_LAMVIEC = value; }
        }

        public string TRINHDO_VANHOA
        {
            get { return mvarTRINHDO_VANHOA; }
            set { mvarTRINHDO_VANHOA = value; }
        }

        public string NOISINH
        {
            get { return mvarNOISINH; }
            set { mvarNOISINH = value; }
        }

        public string QUEQUAN
        {
            get { return mvarQUEQUAN; }
            set { mvarQUEQUAN = value; }
        }

        public string MASOTHUE
        {
            get { return mvarMASOTHUE; }
            set { mvarMASOTHUE = value; }
        }

        public DateTime NGAYVAOLAM
        {
            get { return mvarNGAYVAOLAM; }
            set { mvarNGAYVAOLAM = value; }
        }

        public DateTime NGAYSINH
        {
            get { return mvarNGAYSINH; }
            set { mvarNGAYSINH = value; }
        }

        public string TEN_NHANVIEN
        {
            get { return mvarTEN_NHANVIEN; }
            set { mvarTEN_NHANVIEN = value; }
        }

        #endregion

        #region "Constructors"
        public clsDM_NHANVIEN()
        {
            m_DAL = new DataAccess();
            Reset();
        }

        public clsDM_NHANVIEN(DataAccess mdal)
        {
            m_DAL = mdal;
            Reset();
        }

        public clsDM_NHANVIEN(string mLanguage_Id, Int32 mUser_Id)
        {
            Reset();
            mvarLANGUAGEID = mLanguage_Id;
            USERID = mUser_Id;
            m_DAL = new DataAccess();
        }

        public clsDM_NHANVIEN(DataAccess mdal, string mLanguage_Id, Int32 mUser_Id)
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
                DAL.CommandText = SP_DM_NHANVIEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "AddNew", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@NHANVIEN_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarNHANVIEN_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarNHOMNGUOIDUNG_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@CHUCVU_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarCHUCVU_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@PHONGBAN_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarPHONGBAN_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@MANHANVIEN", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarMANHANVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@HO_NHANVIEN", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarHO_NHANVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@EMAIL_NHANVIEN", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarEMAIL_NHANVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@GIOITINH", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarGIOITINH), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@DIACHI_TAMTRU", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarDIACHI_TAMTRU), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@USERNAME", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarUSERNAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@PW", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarPW), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@ISLOGIN", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarISLOGIN), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_TIME", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarLOGIN_TIME), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_LOGOUT_TIME", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_LOGOUT_TIME), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@CMND_SO", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarCMND_SO), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@CMND_NOICAP", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarCMND_NOICAP), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DANTOC", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarDANTOC), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@TONGIAO", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarTONGIAO), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@DIENTHOAI_NHA", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarDIENTHOAI_NHA), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@DIENTHOAI_DIDONG", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarDIENTHOAI_DIDONG), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@DIACHI_THUONGTRU", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarDIACHI_THUONGTRU), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TRANGTHAI_LAMVIEC", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarTRANGTHAI_LAMVIEC), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@TRINHDO_VANHOA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarTRINHDO_VANHOA), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@NOISINH", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarNOISINH), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@QUEQUAN", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarQUEQUAN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@MASOTHUE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarMASOTHUE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@NGAYVAOLAM", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarNGAYVAOLAM), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@NGAYSINH", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarNGAYSINH), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@TEN_NHANVIEN", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarTEN_NHANVIEN), ParameterDirection.Input, 1000));

                DAL.ExecNonQuery();

                mvarNHANVIEN_ID = Int32.Parse(UTILITIES.clsCommon.GetValue(DAL.Parameters.Items("@NHANVIEN_ID").Value, mvarNHANVIEN_ID.GetType().FullName).ToString());

                return (mvarNHANVIEN_ID > 0);
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
                DAL.CommandText = SP_DM_NHANVIEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Update", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@NHANVIEN_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarNHANVIEN_ID), ParameterDirection.InputOutput, 4));
                DAL.Parameters.Add(new ParamStruct("@NHOMNGUOIDUNG_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarNHOMNGUOIDUNG_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@CHUCVU_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarCHUCVU_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@PHONGBAN_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarPHONGBAN_ID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@MANHANVIEN", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarMANHANVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@HO_NHANVIEN", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarHO_NHANVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@EMAIL_NHANVIEN", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarEMAIL_NHANVIEN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@GIOITINH", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarGIOITINH), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@DIACHI_TAMTRU", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarDIACHI_TAMTRU), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@USERNAME", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarUSERNAME), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@PW", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarPW), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@ISLOGIN", DbType.Boolean, UTILITIES.clsCommon.GetValueDBNull(mvarISLOGIN), ParameterDirection.Input, 2));
                DAL.Parameters.Add(new ParamStruct("@LOGIN_TIME", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarLOGIN_TIME), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_LOGOUT_TIME", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_LOGOUT_TIME), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATION_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarCREATION_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@CREATED_BY", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarCREATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATE_DATE", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_UPDATE_DATE), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@LAST_UPDATED_BY", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarLAST_UPDATED_BY), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@CMND_SO", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarCMND_SO), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@CMND_NOICAP", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarCMND_NOICAP), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@DANTOC", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarDANTOC), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@TONGIAO", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarTONGIAO), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@DIENTHOAI_NHA", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarDIENTHOAI_NHA), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@DIENTHOAI_DIDONG", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarDIENTHOAI_DIDONG), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@DIACHI_THUONGTRU", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarDIACHI_THUONGTRU), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@TRANGTHAI_LAMVIEC", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarTRANGTHAI_LAMVIEC), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@TRINHDO_VANHOA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarTRINHDO_VANHOA), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@NOISINH", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarNOISINH), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@QUEQUAN", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarQUEQUAN), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@MASOTHUE", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarMASOTHUE), ParameterDirection.Input, 1000));
                DAL.Parameters.Add(new ParamStruct("@NGAYVAOLAM", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarNGAYVAOLAM), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@NGAYSINH", DbType.DateTime, UTILITIES.clsCommon.GetValueDBNull(mvarNGAYSINH), ParameterDirection.Input, 16));
                DAL.Parameters.Add(new ParamStruct("@TEN_NHANVIEN", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarTEN_NHANVIEN), ParameterDirection.Input, 1000));

                return (DAL.ExecNonQuery() > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int NHANVIEN_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_NHANVIEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Delete", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));
                DAL.Parameters.Add(new ParamStruct("@NHANVIEN_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(NHANVIEN_ID), ParameterDirection.InputOutput, 4));
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
                DAL.CommandText = SP_DM_NHANVIEN;
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

        public bool GetByKey(int NHANVIEN_ID)
        {
            DataAccess DAL = m_DAL;
            try
            {
                DataSet ds = new DataSet();
                DAL.CommandType = CommandType.StoredProcedure;
                DAL.CommandText = SP_DM_NHANVIEN;
                DAL.Parameters.Clear();
                DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "GetByKey", ParameterDirection.Input, 50));
                DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
                DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

                DAL.Parameters.Add(new ParamStruct("@NHANVIEN_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(NHANVIEN_ID), ParameterDirection.InputOutput, 4));
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

            mvarNHANVIEN_ID = Int32.MinValue;
            mvarNHOMNGUOIDUNG_ID = Int32.MinValue;
            mvarCHUCVU_ID = Int32.MinValue;
            mvarPHONGBAN_ID = Int32.MinValue;
            mvarMANHANVIEN = string.Empty;
            mvarHO_NHANVIEN = string.Empty;
            mvarEMAIL_NHANVIEN = string.Empty;
            mvarGIOITINH = false;
            mvarDIACHI_TAMTRU = string.Empty;
            mvarUSERNAME = string.Empty;
            mvarPW = string.Empty;
            mvarISLOGIN = false;
            mvarLOGIN_TIME = DateTime.MinValue;
            mvarLAST_LOGOUT_TIME = DateTime.MinValue;
            mvarCREATION_DATE = DateTime.MinValue;
            mvarCREATED_BY = Int32.MinValue;
            mvarLAST_UPDATE_DATE = DateTime.MinValue;
            mvarLAST_UPDATED_BY = Int32.MinValue;
            mvarCMND_SO = string.Empty;
            mvarCMND_NOICAP = string.Empty;
            mvarDANTOC = Int32.MinValue;
            mvarTONGIAO = Int32.MinValue;
            mvarDIENTHOAI_NHA = Int32.MinValue;
            mvarDIENTHOAI_DIDONG = Int32.MinValue;
            mvarDIACHI_THUONGTRU = string.Empty;
            mvarTRANGTHAI_LAMVIEC = Int32.MinValue;
            mvarTRINHDO_VANHOA = string.Empty;
            mvarNOISINH = string.Empty;
            mvarQUEQUAN = string.Empty;
            mvarMASOTHUE = string.Empty;
            mvarNGAYVAOLAM = DateTime.MinValue;
            mvarNGAYSINH = DateTime.MinValue;
            mvarTEN_NHANVIEN = string.Empty;
        }

        public void FillData(DataRow row)
        {

            mvarNHANVIEN_ID = Int32.Parse(UTILITIES.clsCommon.GetValue(row["NHANVIEN_ID"], mvarNHANVIEN_ID.GetType().FullName).ToString());
            mvarNHOMNGUOIDUNG_ID = Int32.Parse(UTILITIES.clsCommon.GetValue(row["NHOMNGUOIDUNG_ID"], mvarNHOMNGUOIDUNG_ID.GetType().FullName).ToString());
            mvarCHUCVU_ID = Int32.Parse(UTILITIES.clsCommon.GetValue(row["CHUCVU_ID"], mvarCHUCVU_ID.GetType().FullName).ToString());
            mvarPHONGBAN_ID = Int32.Parse(UTILITIES.clsCommon.GetValue(row["PHONGBAN_ID"], mvarPHONGBAN_ID.GetType().FullName).ToString());
            mvarMANHANVIEN = UTILITIES.clsCommon.GetValue(row["MANHANVIEN"], mvarMANHANVIEN.GetType().FullName).ToString();
            mvarHO_NHANVIEN = UTILITIES.clsCommon.GetValue(row["HO_NHANVIEN"], mvarHO_NHANVIEN.GetType().FullName).ToString();
            mvarEMAIL_NHANVIEN = UTILITIES.clsCommon.GetValue(row["EMAIL_NHANVIEN"], mvarEMAIL_NHANVIEN.GetType().FullName).ToString();
            mvarGIOITINH = Boolean.Parse(UTILITIES.clsCommon.GetValue(row["GIOITINH"], mvarGIOITINH.GetType().FullName).ToString());
            mvarDIACHI_TAMTRU = UTILITIES.clsCommon.GetValue(row["DIACHI_TAMTRU"], mvarDIACHI_TAMTRU.GetType().FullName).ToString();
            mvarUSERNAME = UTILITIES.clsCommon.GetValue(row["USERNAME"], mvarUSERNAME.GetType().FullName).ToString();
            mvarPW = UTILITIES.clsCommon.GetValue(row["PW"], mvarPW.GetType().FullName).ToString();
            mvarISLOGIN = Boolean.Parse(UTILITIES.clsCommon.GetValue(row["ISLOGIN"], mvarISLOGIN.GetType().FullName).ToString());
            mvarLOGIN_TIME = DateTime.Parse(UTILITIES.clsCommon.GetValue(row["LOGIN_TIME"], mvarLOGIN_TIME.GetType().FullName).ToString());
            mvarLAST_LOGOUT_TIME = DateTime.Parse(UTILITIES.clsCommon.GetValue(row["LAST_LOGOUT_TIME"], mvarLAST_LOGOUT_TIME.GetType().FullName).ToString());
            mvarCREATION_DATE = DateTime.Parse(UTILITIES.clsCommon.GetValue(row["CREATION_DATE"], mvarCREATION_DATE.GetType().FullName).ToString());
            mvarCREATED_BY = Int32.Parse(UTILITIES.clsCommon.GetValue(row["CREATED_BY"], mvarCREATED_BY.GetType().FullName).ToString());
            mvarLAST_UPDATE_DATE = DateTime.Parse(UTILITIES.clsCommon.GetValue(row["LAST_UPDATE_DATE"], mvarLAST_UPDATE_DATE.GetType().FullName).ToString());
            mvarLAST_UPDATED_BY = Int32.Parse(UTILITIES.clsCommon.GetValue(row["LAST_UPDATED_BY"], mvarLAST_UPDATED_BY.GetType().FullName).ToString());
            mvarCMND_SO = UTILITIES.clsCommon.GetValue(row["CMND_SO"], mvarCMND_SO.GetType().FullName).ToString();
            mvarCMND_NOICAP = UTILITIES.clsCommon.GetValue(row["CMND_NOICAP"], mvarCMND_NOICAP.GetType().FullName).ToString();
            mvarDANTOC = Int32.Parse(UTILITIES.clsCommon.GetValue(row["DANTOC"], mvarDANTOC.GetType().FullName).ToString());
            mvarTONGIAO = Int32.Parse(UTILITIES.clsCommon.GetValue(row["TONGIAO"], mvarTONGIAO.GetType().FullName).ToString());
            mvarDIENTHOAI_NHA = Int32.Parse(UTILITIES.clsCommon.GetValue(row["DIENTHOAI_NHA"], mvarDIENTHOAI_NHA.GetType().FullName).ToString());
            mvarDIENTHOAI_DIDONG = Int32.Parse(UTILITIES.clsCommon.GetValue(row["DIENTHOAI_DIDONG"], mvarDIENTHOAI_DIDONG.GetType().FullName).ToString());
            mvarDIACHI_THUONGTRU = UTILITIES.clsCommon.GetValue(row["DIACHI_THUONGTRU"], mvarDIACHI_THUONGTRU.GetType().FullName).ToString();
            mvarTRANGTHAI_LAMVIEC = Int32.Parse(UTILITIES.clsCommon.GetValue(row["TRANGTHAI_LAMVIEC"], mvarTRANGTHAI_LAMVIEC.GetType().FullName).ToString());
            mvarTRINHDO_VANHOA = UTILITIES.clsCommon.GetValue(row["TRINHDO_VANHOA"], mvarTRINHDO_VANHOA.GetType().FullName).ToString();
            mvarNOISINH = UTILITIES.clsCommon.GetValue(row["NOISINH"], mvarNOISINH.GetType().FullName).ToString();
            mvarQUEQUAN = UTILITIES.clsCommon.GetValue(row["QUEQUAN"], mvarQUEQUAN.GetType().FullName).ToString();
            mvarMASOTHUE = UTILITIES.clsCommon.GetValue(row["MASOTHUE"], mvarMASOTHUE.GetType().FullName).ToString();
            mvarNGAYVAOLAM = DateTime.Parse(UTILITIES.clsCommon.GetValue(row["NGAYVAOLAM"], mvarNGAYVAOLAM.GetType().FullName).ToString());
            mvarNGAYSINH = DateTime.Parse(UTILITIES.clsCommon.GetValue(row["NGAYSINH"], mvarNGAYSINH.GetType().FullName).ToString());
            mvarTEN_NHANVIEN = UTILITIES.clsCommon.GetValue(row["TEN_NHANVIEN"], mvarTEN_NHANVIEN.GetType().FullName).ToString();
        }

        #endregion

        #region "Other Methods"
        //--------------------------------------Các phương thức khác viết ở đây!!!!---------------------------------------------------//
        #endregion

    }
}


