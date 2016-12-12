using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.BLL.DTO
{
    public class clsParameterTransfer
    {
        #region "Variable"
        private int mvarDomain_Id; //Giá trị mặc định :
        private string mvarDomain_Code;//
        private int mvarUser_Id; //Giá trị mặc định :
        private string mvarUser_Code; //Giá trị mặc định :
        private int mvarUserLoginSession_Id; //Giá trị mặc định :

        //----------------------------------------------------------

        #endregion

        #region "Variable"
        public int Domain_Id
        {
            get { return mvarDomain_Id; }
            set { mvarDomain_Id = value; }
        }
        public string Domain_Code
        {
            get { return mvarDomain_Code; }
            set { mvarDomain_Code = value; }
        }
        public int User_Id
        {
            get { return mvarUser_Id; }
            set { mvarUser_Id = value; }
        }
        public string User_Code
        {
            get { return mvarUser_Code; }
            set { mvarUser_Code = value; }
        }
        public int UserLoginSession_Id
        {
            get { return mvarUserLoginSession_Id; }
            set { mvarUserLoginSession_Id = value; }
        }

        #endregion

        public clsParameterTransfer()
        {

        }

        public clsParameterTransfer(int intDomain_Id, int intUser_Id)
        {
            Domain_Id = intDomain_Id;
            User_Id = intUser_Id;
        }
        public clsParameterTransfer(int intDomain_Id, string strBenhVien_Code, int intUser_Id, string strUser_Code, int intLoginSession_Id)
        {
            Domain_Id = intDomain_Id;
            Domain_Code = strBenhVien_Code;
            User_Id = intUser_Id;
            User_Code = strUser_Code;
            UserLoginSession_Id = intLoginSession_Id;
        }
    }
}
