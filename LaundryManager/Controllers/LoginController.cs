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
    }
}
