using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Models
{
    class BillDetailsModel
    {
        protected string billCode { get; set; }
        protected string servID { get; set; }
        protected Int32 quantity { get; set; }
        protected double price { get; set; }
        protected double total { get; set; }

        public BillDetailsModel()
        {
        }

        public BillDetailsModel(string billCode, string servID, int quantity, double price, double total)
        {
            this.billCode = billCode;
            this.servID = servID;
            this.quantity = quantity;
            this.price = price;
            this.total = total;
        }

        public BillDetailsModel(string billCode)
        {
            this.billCode = billCode;
        }

        public BillDetailsModel(string billCode, string servID)
        {
            this.billCode = billCode;
            this.servID = servID;
        }

        public int InsertBillDetails()
        {
            int i = 0;
            string[] paras = new string[5] { "@BillCode", "@ServID", "@Quantity", "@Price", "@Total" };
            object[] values = new object[5] { billCode, servID, quantity, price, total }
;
            i = Models.Connection.Excute_Sql("spInsertBillDetails", CommandType.StoredProcedure, paras, values);

            return i;
        }


        public int UpdateBillDetails()
        {
            int i = 0;
            string[] paras = new string[5] { "@BillCode", "@ServID", "@Quantity", "@Price", "@Total" };
            object[] values = new object[5] { billCode, servID, quantity, price, total }
;
            i = Models.Connection.Excute_Sql("spUpdateBillDetails", CommandType.StoredProcedure, paras, values);

            return i;
        }


        public int DeleteBillDetails()
        {
            int i = 0;
            string[] paras = new string[2] { "@BillCode", "@ServID" };
            object[] values = new object[2] { billCode, servID };

            i = Models.Connection.Excute_Sql("spDeleteBillDetails", CommandType.StoredProcedure, paras, values);

            return i;
        }


        public DataSet FillDataSetCart()
        {

            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@BillCode" };
            object[] values = new object[1] { billCode };

            ds = Models.Connection.FillDataSet("spShowBillDetails", CommandType.StoredProcedure, paras, values);
            ds.Tables[0].TableName = "Cart";

            return ds;
        }
    }
}
