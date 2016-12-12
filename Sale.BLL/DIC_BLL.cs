using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

using Sale.BLL.DTO;
using Sale.DAL;
using Sale.Entities;
using Sale.UTILITIES;

using NLog;

namespace Sale.BLL
{
    public class DIC_BLL
    {
        private Logger Mylogger = LogManager.GetCurrentClassLogger();

        //public DataTable Get_PROVINCE()
        //{
        //    DataAccess DAL = m_DAL;
        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        DAL.CommandType = CommandType.StoredProcedure;
        //        DAL.CommandText = SP_MISCELLANEOUS;
        //        DAL.Parameters.Clear();
        //        DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Get_PROVINCE", ParameterDirection.Input, 50));
        //        DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
        //        DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
        //        DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

        //        ds = DAL.ExecDataSet();
        //        return ds.Tables[0];

        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}

        //public DataTable Get_District_By_Province(string PROVINCE_ID)
        //{
        //    DataAccess DAL = m_DAL;
        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        DAL.CommandType = CommandType.StoredProcedure;
        //        DAL.CommandText = SP_MISCELLANEOUS;
        //        DAL.Parameters.Clear();
        //        DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Get_District_By_Province", ParameterDirection.Input, 50));
        //        DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
        //        DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
        //        DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

        //        DAL.Parameters.Add(new ParamStruct("@PROVINCE_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(PROVINCE_ID), ParameterDirection.InputOutput, 4));

        //        ds = DAL.ExecDataSet();
        //        return ds.Tables[0];

        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}

        //public DataTable Get_Ward_By_District(string DISTRICT_ID)
        //{
        //    DataAccess DAL = m_DAL;
        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        DAL.CommandType = CommandType.StoredProcedure;
        //        DAL.CommandText = SP_MISCELLANEOUS;
        //        DAL.Parameters.Clear();
        //        DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Get_Ward_By_District", ParameterDirection.Input, 50));
        //        DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
        //        DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
        //        DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

        //        DAL.Parameters.Add(new ParamStruct("@DISTRICT_ID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(DISTRICT_ID), ParameterDirection.InputOutput, 4));

        //        ds = DAL.ExecDataSet();
        //        return ds.Tables[0];

        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}

        //public DataTable Get_DANTOC()
        //{
        //    DataAccess DAL = m_DAL;
        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        DAL.CommandType = CommandType.StoredProcedure;
        //        DAL.CommandText = SP_MISCELLANEOUS;
        //        DAL.Parameters.Clear();
        //        DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Get_DANTOC", ParameterDirection.Input, 50));
        //        DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
        //        DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
        //        DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

        //        ds = DAL.ExecDataSet();
        //        return ds.Tables[0];

        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}

        //public DataTable Get_TONGIAO()
        //{
        //    DataAccess DAL = m_DAL;
        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        DAL.CommandType = CommandType.StoredProcedure;
        //        DAL.CommandText = SP_MISCELLANEOUS;
        //        DAL.Parameters.Clear();
        //        DAL.Parameters.Add(new ParamStruct("@Action", DbType.String, "Get_TONGIAO", ParameterDirection.Input, 50));
        //        DAL.Parameters.Add(new ParamStruct("@LANGUAGEID", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarLANGUAGEID), ParameterDirection.Input, 4));
        //        DAL.Parameters.Add(new ParamStruct("@USERID", DbType.Int32, UTILITIES.clsCommon.GetValueDBNull(mvarUSERID), ParameterDirection.Input, 4));
        //        DAL.Parameters.Add(new ParamStruct("@FREEPARA", DbType.String, UTILITIES.clsCommon.GetValueDBNull(mvarFREEPARA), ParameterDirection.InputOutput, 1000));

        //        ds = DAL.ExecDataSet();
        //        return ds.Tables[0];

        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}
    }
}
