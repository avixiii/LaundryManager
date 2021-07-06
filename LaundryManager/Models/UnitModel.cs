using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Models
{
    class UnitModel
    {

        protected string unitID { get; set; }
        protected string unit { get; set; }
        protected string note { get; set; }

        public UnitModel(string unitID, string unit, string note)
        {
            this.unitID = unitID;
            this.unit = unit;
            this.note = note;
        }

        public int InsertUnit()
        {
            int i = 0;

            string[] paras = new string[3] { "@ID", "@Unit", "@Note" };
            object[] values = new object[3] { unitID, unit, note };

            i = Models.Connection.Excute_Sql("spInsertUnit", CommandType.StoredProcedure, paras, values);

            return i;
        }
    }
}
