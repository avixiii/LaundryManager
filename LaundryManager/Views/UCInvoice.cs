using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManager.Views
{
    public partial class UCInvoice : System.Windows.Forms.UserControl
    {

        string sqlConn = @"Data Source=DESKTOP-UKLD1J8;Initial Catalog=DATABASE_QUANLYTIEMGIATUI;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;

        public UCInvoice()
        {
            InitializeComponent();
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            fCreateBill fCreateBill = new fCreateBill();
            fCreateBill.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
        }

        private void UCInvoice_Load(object sender, EventArgs e)
        {
            ShowInvoice();
        }

        public DataTable getData(string query)
        {

            if (conn == null)
            {
                conn = new SqlConnection(sqlConn);
                conn.Open();
            }
            DataTable dt = new DataTable();

            da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            da.Fill(dt);
            return dt;
        }
        public void ShowInvoice()
        {
            string sqlBills = "SELECT BillCode, BillDate, Name, AppointmentDate, Phone, Address, Status, Total FROM dbo.Customers , dbo.Bills WHERE dbo.Customers.ID = dbo.Bills.CusID";
            string sqlBillDetails = "SELECT BillDetails.BillCode, ServiceName, BillDetails.Price, Quantity, BillDetails.Total FROM dbo.Services, dbo.BillDetails WHERE dbo.BillDetails.ServID = dbo.Services.ID";


            DataTable bills = new DataTable();
            bills = getData(sqlBills);
            DataTable billDetails = new DataTable();
            billDetails = getData(sqlBillDetails);

            bills.TableName = "Bills";
            billDetails.TableName = "Units";
            ds = new DataSet();
            ds.Tables.Add(bills);
            ds.Tables.Add(billDetails);

            DataRelation dr = new DataRelation("Test", bills.Columns["BillCode"], billDetails.Columns["BillCode"], false);


            try
            {

                ds.Relations.Add(ds.Tables["Bills"].Columns["BillCode"], ds.Tables["Units"].Columns["BillCode"]);

            }
            catch (Exception ex)
            { }


            //ds.Relations.Add(dr);

            gcInvoice.DataSource = ds;
            gcInvoice.DataMember = "Bills";

        }

        private void riBtnStatus_Click(object sender, EventArgs e)
        {
            fBillStatus status = new fBillStatus();
            status.ShowDialog();
        }
    }
}
