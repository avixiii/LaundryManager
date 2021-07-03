using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Controllers
{
    class BackupController
    {
        public static string Backup(string _path, string _fileName)
        {
            string str = "";
            try
            {
                Models.BackupModel backup = new Models.BackupModel(_path, _fileName);
                return backup.Backup();
            }
            catch { 
            }

            return str;
        }
    }
}
