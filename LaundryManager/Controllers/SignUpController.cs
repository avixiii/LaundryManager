using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Controllers
{
    class SignUpController
    {
        public static string CheckUser(string _user)
        {
            try
            {
                Models.SignUpModel checkUser = new Models.SignUpModel(_user);
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
                Models.SignUpModel signUp = new Models.SignUpModel(_user, _pass, _fullName, _phone, _address, _birthDay, idCard, _status);
                return signUp.SignUp();

            }
            catch { return 0; }
        }    

    }
}
