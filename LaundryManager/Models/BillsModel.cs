using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Models
{
    class BillsModel
    {
        public BillsModel(string billCode, int cusID, int userID, DateTime billDate, DateTime appointmentDate, DateTime recieveDate, double discount, double surcharge, double mustBePaid, double paid, string note, string status)
        {
            this.billCode = billCode;
            this.cusID = cusID;
            this.userID = userID;
            this.billDate = billDate;
            this.appointmentDate = appointmentDate;
            this.recieveDate = recieveDate;
            this.discount = discount;
            this.surcharge = surcharge;
            this.mustBePaid = mustBePaid;
            this.paid = paid;
            this.note = note;
            this.status = status;
        }

        public BillsModel(string billCode, int cusID, int userID, DateTime billDate, DateTime appointmentDate, double discount, double surcharge, string note, double total)
        {
            this.billCode = billCode;
            this.cusID = cusID;
            this.userID = userID;
            this.billDate = billDate;
            this.appointmentDate = appointmentDate;
            this.discount = discount;
            this.surcharge = surcharge;
            this.note = note;
            this.total = total;
        }

        public BillsModel(string billCode, int userID, DateTime billDate, DateTime appointmentDate, double discount, double surcharge, string note, double total, string status)
        {
            this.billCode = billCode;
            this.cusID = cusID;
            this.userID = userID;
            this.billDate = billDate;
            this.appointmentDate = appointmentDate;
            this.discount = discount;
            this.surcharge = surcharge;
            this.note = note;
            this.total = total;
            this.status = status;
        }

        public BillsModel(string billCode, string status)
        {
            this.billCode = billCode;
            this.status = status;
        }

        public BillsModel(string billCode, double paid, double mustBePaid)
        {
            this.billCode = billCode;
            this.paid = paid;
            this.mustBePaid = mustBePaid;
        }

        public BillsModel(string billCode)
        {
            this.billCode = billCode;
        }

        protected string billCode { get; set; }
        protected int cusID { get; set; }
        protected int userID { get; set; }
        protected DateTime billDate { get; set; }
        protected DateTime appointmentDate { get; set; }
        protected DateTime recieveDate { get; set; }
        protected double discount { get; set; }
        protected double surcharge { get; set; }
        protected double mustBePaid { get; set; }
        protected double paid { get; set; }
        protected string note { get; set; }
        protected string status { get; set; }
        protected double total { get; set; }


        // Insert 
        public int InsertBill()
        {
            int i = 0;
            string[] paras = new string[9] { "@BillCode", "@CusID", "UserID", "@BillDate", "@AppointmentDate", "@Discount", "@Surcharge", "@Note", "@Total" };
            object[] values = new object[9] { billCode, cusID, userID, billDate, appointmentDate, discount, surcharge, note, total };

            i = Models.Connection.Excute_Sql("spInsertBill", CommandType.StoredProcedure, paras, values);

            return i;
        }

        // Delete 

        public int Delete()
        {
            int i = 0;
            string[] paras = new string[1] { "@BillCode" };
            object[] values = new object[1] { billCode };

            i = Models.Connection.Excute_Sql("spDeleteBill", CommandType.StoredProcedure, paras, values);

            return i;
        }


        // Update
        public int UpdateBill()
        {

            int i = 0;
            string[] paras = new string[9] { "@BillCode", "UserID", "@BillDate", "@AppointmentDate", "@Discount", "@Surcharge", "@Note", "@Total", "@Status" };
            object[] values = new object[9] { billCode, userID, billDate, appointmentDate, discount, surcharge, note, total, status };

            i = Models.Connection.Excute_Sql("spUpdateBill", CommandType.StoredProcedure, paras, values);

            return i;
        }    


        // Update Status
        public int UpdateStatus()
        {
            int i = 0;
            string[] paras = new string[2] { "@BillCode", "@Status" };
            object[] values = new object[2] { billCode, status };

            i = Models.Connection.Excute_Sql("spUpdateStatus", CommandType.StoredProcedure, paras, values);

            return i;
        }

        // Payment
        public int Payment()
        {
            int i = 0;
            string[] paras = new string[3] { "@BillCode" , "@Paid", "@MustBePaid"};
            object[] values = new object[3] { billCode, paid, mustBePaid };

            i = Models.Connection.Excute_Sql("spPayment", CommandType.StoredProcedure, paras, values);

            return i;
        }

        // get info for update bill
        public DataTable GetInfo()
        {
            DataTable dt = null;
            string query = "SELECT Status, BillDate, AppointmentDate, Name, Phone, Discount, Total, Surcharge, Address, NOTE FROM dbo.Bills, dbo.Customers WHERE CusID = ID AND BillCode = '" + billCode + "'";

            dt = Models.Connection.FillDataTable(query);
            dt.TableName = "info";

            return dt;
        }

        // LAY ID CUSTOMER 
        public int GetCusID()
        {
            int i = 1;

            string query = "SELECT CusID FROM dbo.Bills WHERE BillCode = '" + billCode + "'";
            DataTable dt = Models.Connection.FillDataTable(query);
            
            if (dt != null)
            {
                i = (int)dt.Rows[0][0];
            }

            return i;
        }
    }
}
