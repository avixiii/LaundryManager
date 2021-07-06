using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Models
{
    class RestoreModel
    {
        protected string path { get; set; }

        public RestoreModel(string path)
        {
            this.path = path;
        }

        public string Restore()
        {
            string str = "abc";

            string[] paras = new string[1] { "@path"};
            string[] values = new string[1] { path };

            Models.Connection.ExcuteScalar("spRestore", CommandType.StoredProcedure, paras, values);

            return str;
        }
    }
}
