using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Threading.Tasks;

namespace Sale.BLL.DTO
{
    public class clsResponseString
    {
        private int mvarResultValue; //Quuy uoc tham số :
        private string mvarResultMessage;//chuoi tra ve voi thong bao loi tuong ung
        //1 : thêm , cập nhật , xóa  thành công
        //0 : thêm , cập nhật , xóa không thành công
        //2: không tồn tại giá trị này!!!
        //3 : tham số không hợp lệ
        //5 : authentication fails
        private object mvarObjectReturn;//chuoi tra ve tuong ung
        private DataTable mvarObjectReturnDetails;//chuoi tra ve tuong ung voi bang chi tiet

        public int ResultValue
        {
            get { return mvarResultValue; }
            set { mvarResultValue = value; }
        }

        public string ResultMessage
        {
            get { return mvarResultMessage; }
            set { mvarResultMessage = value; }
        }

        public object ObjectReturn
        {
            get { return mvarObjectReturn; }
            set { mvarObjectReturn = value; }
        }

        public DataTable DataStringDetails
        {
            get { return mvarObjectReturnDetails; }
            set { mvarObjectReturnDetails = value; }
        }
    }
}
