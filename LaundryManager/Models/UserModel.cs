using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Models
{
    class UserModel
    {
        protected string user { get; set; }
        protected string pass { get; set; }
        protected string fullName { get; set; }
        protected string phone { get; set; }
        protected string address { get; set; }
        protected string birthDay { get; set; }
        protected string idCard { get; set; }
        protected bool status { get; set; }


        public UserModel(string user, string pass, string fullName, string phone, string address, string birthDay, string idCard, bool status)
        {
            this.user = user;
            this.pass = pass;
            this.fullName = fullName;
            this.phone = phone;
            this.address = address;
            this.birthDay = birthDay;
            this.idCard = idCard;
            this.status = status;
        }

        public UserModel(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }

        public UserModel(string user)
        {
            this.user = user;
        }

        // ================= Login ================
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

        public string CheckStatus()
        {
            string str = "";
            string[] paras = new string[2] { "@Username", "@Password" };
            object[] values = new object[2] { user, pass };

            str = Models.Connection.ExcuteScalar("spCheckStatus", CommandType.StoredProcedure, paras, values);

            return str;
        }

        public int GetID()
        {
            int i = 0;
            string[] paras = new string[2] { "@Username", "@Password" };
            object[] values = new object[2] { user, pass };

            string query = "SELECT * FROM dbo.Users WHERE UserName = " + "'" + user + "' AND Password = '" + pass + "'";

            DataTable dt = Models.Connection.FillDataTable(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    i = (int)dr["ID"];
                }
            }

            return i;
        }

        // ================= Sign Up ==============
        public string CheckUser()
        {
            string str = "";
            string[] paras = new string[1] { "@Username" };
            object[] values = new object[1] { user };

            str = Models.Connection.ExcuteScalar("spCheckUser", CommandType.StoredProcedure, paras, values);

            return str;
        }

        public int SignUp()
        {
            int i = 0;
            string[] paras = new string[8] { "@UserName", "@Password", "@FullName", "@Phone", "@Address", "@Birthday", "@IDCard", "@Status" };
            object[] values = new object[8] { user, pass, fullName, phone, address, birthDay, idCard, status };

            i = Models.Connection.Excute_Sql("spSignUp", CommandType.StoredProcedure, paras, values);

            return i;

        }

        // ========== Change Pass ==================
        public string ChangePass()
        {
            string str = "";
            string[] paras = new string[2] { "@Username", "@Password" };
            object[] values = new object[2] { user, pass };

            str = Models.Connection.ExcuteScalar("spChangePass", CommandType.StoredProcedure, paras, values);

            return str;
        }

        // ============== XOÁ USER ====================
        public int DeleteUser()
        {
            int i = 0;
            string[] paras = new string[1] { "@Username" };
            object[] values = new object[1] { user };

            i = Models.Connection.Excute_Sql("spDeleteUser", CommandType.StoredProcedure, paras, values);

            return i;
        }

        //

    }
}
