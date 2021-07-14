using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Models
{
    class CustomerModel
    {
        public CustomerModel(string name, string address, string phone, double totalBill)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.totalBill = totalBill;
        }

        public CustomerModel()
        {
        }

        protected string name { get; set; }
        protected string address { get; set; }
        protected string phone { get; set; }
        protected double totalBill { get; set; }

        public int InsertCustomer()
        {
            int i = 0;

            string[] paras = new string[4] { "@Name", "@Address", "@Phone", "@TotalBill" };
            object[] values = new object[4] { name, address, phone, totalBill };
            i = Models.Connection.Excute_Sql("spInsertCustomer", CommandType.StoredProcedure ,paras, values);
            return i;
        }

        public int GetID()
        {
            int i = 1;

            string query = "SELECT * FROM dbo.Customers WHERE id=(SELECT max(id) FROM dbo.Customers)";
            DataTable dt = Models.Connection.FillDataTable(query);

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    i = (int)dr["ID"];
                }
            }

            return i;

        }


        public static DataSet FillDataSetCustomers()
        {
            string sqlCustomers = "SELECT ID, Name, Address, Phone, TotalBill FROM dbo.Customers";
            string sqlBills = "SELECT BillCode, CusID, BillDate, Name, AppointmentDate, Phone, Address, Status, Total, Paid, MustBePaid FROM dbo.Customers , dbo.Bills WHERE dbo.Customers.ID = dbo.Bills.CusID";

            DataTable customers = new DataTable();
            customers = Models.Connection.FillDataTable(sqlCustomers);
            DataTable bills = new DataTable();
            bills = Models.Connection.FillDataTable(sqlBills);

            customers.TableName = "Customers";
            bills.TableName = "Bills";

            DataSet ds = new DataSet();
            ds = new DataSet();
            ds.Tables.Add(customers);
            ds.Tables.Add(bills);

            DataRelation dr = new DataRelation("Test",customers.Columns["ID"],  bills.Columns["CusID"], false);

            try
            {

                ds.Relations.Add(ds.Tables["Customers"].Columns["ID"], ds.Tables["Bills"].Columns["CusID"]);

            }
            catch (Exception ex)
            { }

            return ds;
        }
    }
}
