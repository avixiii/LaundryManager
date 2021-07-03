using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Models
{
    class LoginModel
    {
        // Khai báo biến
        protected string user { get; set; }
        protected string pass { get; set; }
        // Biến status sau này ta dùng để kiểm tra trạng thái tài khoản
        protected bool status { get; set; }

        // Hàm khởi tạo 2 đối số để kiểm tra đăng nhập

        public LoginModel(string _user, string _pass)
        {
            this.user = _user;
            this.pass = _pass;
        }

        // Check đăng nhập
        public string CheckLogin()
        {
            string str = "";
            // Truyền vào 2 biến UserName và Password. 2 biến này phải trùng với CSDL
            string[] para = new string[2] { "@Username", "@Password" };
            object[] value = new object[2] { user, pass };

            str = Models.Connection.ExcuteScalar("spCheckLogin", CommandType.StoredProcedure, para, value);

            return str;
        }

        public string ChangePass()
        {
            string str = "";
            string[] paras = new string[2] { "@Username", "@Password" };
            object[] values = new object[2] { user, pass };

            str = Models.Connection.ExcuteScalar("spChangePass", CommandType.StoredProcedure, paras, values);

            return str;
        }
    }
}
