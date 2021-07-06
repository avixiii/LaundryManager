using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Models
{
    class DataModel
    {
        protected string path { get; set; }
        protected string fileName { get; set; }

        public DataModel(string path)
        {
            this.path = path;
        }
        public DataModel(string path, string fileName)
        {
            this.path = path;
            this.fileName = fileName;
        }

        // Backup
        public string Backup()
        {
            string str = "abc";
            string[] paras = new string[2] { "@path", "@fileName" };
            string[] values = new string[2] { path, fileName };

            str = Models.Connection.ExcuteScalar("spBackup", CommandType.StoredProcedure, paras, values);

            return str;
        }

        // Restore
        public string Restore()
        {
            string str = "abc";

            string[] paras = new string[1] { "@path" };
            string[] values = new string[1] { path };

            Models.Connection.ExcuteScalar("spRestore", CommandType.StoredProcedure, paras, values);

            return str;
        }

    }
}
