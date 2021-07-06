using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Models
{
    class ServiceModel
    {
        protected string serviceID { get; set; }
        protected string serviceName { get; set; }
        protected string unitID { get; set; }
        protected string price { get; set; }
        protected string note { get; set; }


        public ServiceModel() { }


        public ServiceModel(string serviceID)
        {
            this.serviceID = serviceID;
        }

        public ServiceModel(string serviceID, string serviceName, string unitID, string price, string note)
        {
            this.serviceID = serviceID;
            this.serviceName = serviceName;
            this.unitID = unitID;
            this.price = price;
            this.note = note;
        }

        // Insert service
        public int InsertService()
        {
            int i = 0;
            string[] paras = new string[5] { "@ID", "@ServiceName", "UnitID", "@Price", "@Note" };
            object[] values = new object[] { serviceID, serviceName, unitID, price, note };

            i = Models.Connection.Excute_Sql("spInsertService", CommandType.StoredProcedure, paras, values);

            return i;
        }

        // Update service
        public int UpdateService()
        {
            int i = 0;
            string[] paras = new string[5] { "@ID", "@ServiceName", "UnitID", "@Price", "@Note" };
            object[] values = new object[] { serviceID, serviceName, unitID, price, note };

            i = Models.Connection.Excute_Sql("spUpdateService", CommandType.StoredProcedure, paras, values);

            return i;
        }

        // Delete Service

        public int DeleteService()
        {
            int i = 0;
            string[] paras = new string[1] { "@ID" };
            object[] values = new object[1] { serviceID };

            i = Models.Connection.Excute_Sql("spDeleteService", CommandType.StoredProcedure, paras, values);
            return i;
        }
    }
}
