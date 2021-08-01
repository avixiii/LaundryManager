using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManager.Models
{
    class CashBookModel
    {
        public CashBookModel(string id, int userID, string billType, DateTime billDate, string payer, double amount, string reason, string explain)
        {
            this.id = id;
            this.userID = userID;
            this.billType = billType;
            this.billDate = billDate;
            this.payer = payer;
            this.amount = amount;
            this.reason = reason;
            this.explain = explain;
        }

        public CashBookModel(string id)
        {
            this.id = id;
        }

        public CashBookModel()
        {
        }

        


        // string id, string userID, string billType, DateTime billDate, string payer, double amount, string reason, string explain
        protected string id { get; set; }
        protected int userID { get; set; }
        protected string billType { get; set; }
        protected DateTime billDate { get; set; }
        protected string payer { get; set; }
        protected double amount { get; set; }
        protected string reason { get; set; }
        protected string explain { get; set; }

        public static DataSet FillDataSetCashBook()
        {
            DataSet ds = new DataSet();

            string query = "SELECT dbo.CashBook.ID, FullName, BillType, BillDate, Payer, Amount, Reason, Explain FROM dbo.CashBook, dbo.Users WHERE dbo.Users.ID = CashBook.UserID";

            ds = Models.Connection.FillDataSet(query, "CashBook");

            return ds;
        }  

        public int Insert()
        {
            int i = 0;

            string[] paras = new string[8] { "@ID", "@UserID", "@BillType", "@BillDate", "@Payer", "@Amount", "@Reason", "@Explain" };
            object[] values = new object[8] { id, userID, billType, billDate, payer, amount, reason, explain };

            i = Models.Connection.Excute_Sql("spInsertCashbook", CommandType.StoredProcedure, paras, values);

            return i;
        }

        public int Update()
        {
            int i = 0;

            string[] paras = new string[8] { "@ID", "@UserID", "@BillType", "@BillDate", "@Payer", "@Amount", "@Reason", "@Explain" };
            object[] values = new object[8] { id, userID, billType, billDate, payer, amount, reason, explain };

            i = Models.Connection.Excute_Sql("spUpdateCashBook", CommandType.StoredProcedure, paras, values);

            return i;
        }  

        public int Delete()
        {
            int i = 0;

            string[] paras = new string[1] { "@ID"};
            object[] values = new object[1] { id};

            i = Models.Connection.Excute_Sql("spDeleteCashBook", CommandType.StoredProcedure, paras, values);

            return i;
        }
    }
}
