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

        public ServiceModel(string _idService)
        {
            serviceID = _idService;
        }

        public ServiceModel() { }

        public ServiceModel(string _serviceID, string _serviceName, string _unitID, string _price, string _note)
        {
            serviceID = _serviceID;
            serviceName = _serviceName;
            unitID = _unitID;
            price = _price;
            note = _note;
        }

        // Insert service
        public int InsertService()
        {
            int i = 0;
            string[] paras = new string[5] { "@ID", "@ServiceName", "UnitID", "@Price", "@Note" };
            object[] values = new string[] { serviceID, serviceName, unitID, price, note };

            i = Models.Connection.Excute_Sql("spInsertService", CommandType.StoredProcedure, paras, values);

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
