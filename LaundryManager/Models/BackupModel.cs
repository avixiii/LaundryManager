﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Models
{
    class BackupModel
    {
        protected string path { get; set; }
        protected string fileName { get; set; }

        public BackupModel(string _path, string _fileName)
        {
            this.path = _path;
            this.fileName = _fileName;
        }

        public string Backup()
        {
            string str = "abc";
            string[] paras = new string[2] { "@path", "@fileName" };
            string[] values = new string[2] { path, fileName };

            str = Models.Connection.ExcuteScalar("spBackup", CommandType.StoredProcedure, paras, values);

            return str;
        }
    }
}