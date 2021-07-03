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

        public RestoreModel(string _path)
        {
            this.path = _path;
        }

        public string Restore()
        {
            string str = "abc";

            string[] para = new string[1] { "@path"};
            string[] value = new string[1] { path };

            Models.Connection.ExcuteScalar("spRestore", CommandType.StoredProcedure, para, value);

            return str;
        }
    }
}
