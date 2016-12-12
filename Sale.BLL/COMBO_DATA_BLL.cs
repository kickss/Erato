using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NLog;
namespace Sale.BLL
{
    public class COMBO_DATA_BLL
    {
        //khai bao log
        private Logger Mylogger = LogManager.GetCurrentClassLogger();
        //------------------------------------------------------------
        public string GetComboData(string strDataGroup)
        {
             
            try
            {
                return string.Empty; 
            }
            catch (Exception ex)
            {
                return null;  
            }
        }
        public string GetComboDataWithParam(string strDataGroup, string parameterNames, object[] parameterValues)
        {
            try
            {
                return string.Empty; 
            }
            catch (Exception ex)
            {

                this.Mylogger.Fatal("App Combo Data:" + ex.ToString());
                return null; 
                //objReturn.ResultValue = clsContant.CODE_FAIL;
                //objReturn.ResultMessage = ex.Message;
                //return JsonConvert.SerializeObject(objReturn);
            }
        }
    }
}
