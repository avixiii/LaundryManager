using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Models
{
    class SignUpModel
    {
        public SignUpModel(string user)
        {
            this.user = user;
        }

        public SignUpModel(string user, string pass, string fullName, string phone, string address, string birthDay, string idCard, bool status)
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

        protected string user { get; set; }
        protected string pass { get; set; }
        protected string fullName { get; set; }
        protected string phone { get; set; }
        protected string address { get; set; }
        protected string birthDay { get; set; }
        protected string idCard { get; set; }
        protected bool status { get; set; }


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
    }
}
