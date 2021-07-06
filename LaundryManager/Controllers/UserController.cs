using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Controllers
{
    class UserController
    {
        // ==================== Sign Up ===================

        public static string CheckUser(string _user)
        {
            try
            {
                Models.UserModel checkUser = new Models.UserModel(_user);
                return checkUser.CheckUser();
            }
            catch
            {
                return "";
            }
        }

        public static int SignUp(string _user, string _pass, string _fullName, string _phone, string _address, string _birthDay, string idCard, bool _status)
        {
            try
            {
                Models.UserModel signUp = new Models.UserModel(_user, _pass, _fullName, _phone, _address, _birthDay, idCard, _status);
                return signUp.SignUp();

            }
            catch { return 0; }
        }

        // ==================== Login ===================
        public static string CheckLogin(string _user, string _pass)
        {
            try
            {
                Models.UserModel login = new Models.UserModel(_user, _pass);
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
                Models.UserModel login = new Models.UserModel(_user, _pass);
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
                Models.UserModel changePass = new Models.UserModel(_user, _pass);
                return changePass.ChangePass();
            }
            catch { return ""; }
        }


        // ===================== DELETE USER ================
        public static int DeleteUser(string _user)
        {
            try
            {
                Models.UserModel deleteUser = new Models.UserModel(_user);
                return deleteUser.DeleteUser();
            }
            catch { return 0; };
        }


    }
}
