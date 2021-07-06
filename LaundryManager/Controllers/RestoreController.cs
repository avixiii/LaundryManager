using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Controllers
{
    class RestoreController
    {
        public static string Restore(string path)
        {
            string str = "";
            try
            {
                Models.RestoreModel backup = new Models.RestoreModel(path);
                return backup.Restore();
            }
            catch
            {
            }

            return str;
        }
    }
}
