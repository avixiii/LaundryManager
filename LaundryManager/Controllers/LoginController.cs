using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Controllers
{
    class LoginController
    {
        public static string CheckLogin(string _user, string _pass)
        {
            try
            {
                Models.LoginModel login = new Models.LoginModel(_user, _pass);
                return login.CheckLogin();
            }
            catch
            {
                return "";
            }
        }


        public static string CheckStatus(string _user, string _pass)
        {
            try
            {
                Models.LoginModel login = new Models.LoginModel(_user, _pass);
                return login.CheckStatus();
            }
            catch
            {
                return "";
            }
        }

        public static string ChangePass(string _user, string _pass)
        {
            try
            {
                Models.LoginModel changePass = new Models.LoginModel(_user, _pass);
                return changePass.ChangePass();
            }
            catch { return ""; }
        }

       public static int DeleteUser(string _user)
        {
            try
            {
                Models.LoginModel deleteUser = new Models.LoginModel(_user);
                return deleteUser.DeleteUser();
            }
            catch { return 0; };
        }


    }
}
