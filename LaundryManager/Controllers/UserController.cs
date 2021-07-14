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

        public static string CheckUser(string user)
        {
            try
            {
                Models.UserModel checkUser = new Models.UserModel(user);
                return checkUser.CheckUser();
            }
            catch
            {
                return "";
            }
        }

        public static int SignUp(string user, string pass, string fullName, string phone, string address, string birthDay, string idCard, bool status)
        {
            try
            {
                Models.UserModel signUp = new Models.UserModel(user, pass, fullName, phone, address, birthDay, idCard, status);
                return signUp.SignUp();

            }
            catch { return 0; }
        }

        // ==================== Login ===================
        public static string CheckLogin(string user, string pass)
        {
            try
            {
                Models.UserModel login = new Models.UserModel(user, pass);
                return login.CheckLogin();
            }
            catch
            {
                return "";
            }
        }


        public static string CheckStatus(string user, string pass)
        {
            try
            {
                Models.UserModel login = new Models.UserModel(user, pass);
                return login.CheckStatus();
            }
            catch
            {
                return "";
            }
        }

        public static string ChangePass(string user, string pass)
        {
            try
            {
                Models.UserModel changePass = new Models.UserModel(user, pass);
                return changePass.ChangePass();
            }
            catch { return ""; }
        }

        // ==================== GET ID USER ===================
        public static int GetID(string user, string pass)
        {
            try
            {
                Models.UserModel getID = new Models.UserModel(user, pass);
                return getID.GetID();
            }catch { return 0; }
        }
        

        // ===================== DELETE USER ================
        public static int DeleteUser(string user)
        {
            try
            {
                Models.UserModel deleteUser = new Models.UserModel(user);
                return deleteUser.DeleteUser();
            }
            catch { return 0; };
        }

        // Update 

        public static int Update(string user, string fullName, string phone, string address, string birthDay, string idCard, bool status)
        {
            try
            {
                Models.UserModel update = new Models.UserModel(user, fullName, phone, address, birthDay, idCard, status);
                return update.Update();

            }
            catch { return 0; }
        }
    }
}
