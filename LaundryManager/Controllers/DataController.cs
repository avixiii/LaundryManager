using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Controllers
{
    class DataController
    {
        // Backup
        public static string Backup(string path, string fileName)
        {
            string str = "";
            try
            {
                Models.BackupModel backup = new Models.BackupModel(path, fileName);
                return backup.Backup();
            }
            catch
            {
            }

            return str;
        }

        // Restore
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
