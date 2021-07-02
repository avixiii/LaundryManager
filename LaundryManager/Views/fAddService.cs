using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManager.Views
{
    public partial class fAddService : DevExpress.XtraEditors.XtraForm
    {
        public fAddService()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAddService_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsUnits.Units' table. You can move, or remove it, as needed.
            this.unitsTableAdapter.Fill(this.dsUnits.Units);
            txtID.Enabled = false;
            // Load Service ID
            txtID.Text = Models.Connection.ExcuteScalar(String.Format("select ID = dbo.fcgetServiceID()"));
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            string serviceID = txtID.Text;
            string serviceName = txtServiceName.Text;
            string unitId = cbUnits.SelectedValue.ToString();
            string price = txtPrice.Text;
            string note = rtbNote.Text;

            if (serviceName == "" || price == "")
            {
                XtraMessageBox.Show("Vui lòng nhập đầy thông tin.");
            }



            /*
            string str = serviceID + " " + serviceName + " " + unitId + " " + price + " " + note;
            XtraMessageBox.Show(str);
             */

            // Có data được nhập vào.

            int result = Controllers.ServiceController.InsertService(serviceID, serviceName, unitId, price, note);

            if (result == 0)
            {
                XtraMessageBox.Show("Loi??");
            }
            else
            {
                XtraMessageBox.Show("Thêm thành công.");
            }    

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}