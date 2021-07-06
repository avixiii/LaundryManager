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
    public partial class fEditService : DevExpress.XtraEditors.XtraForm
    {
        private string serviceID;
        private string serviceName;
        private string price;
        private string unitID;
        private string note;
        public fEditService()
        {
            InitializeComponent();
        }

        public fEditService(string serviceID, string serviceName, string price, string unitID, string note) : this()
        {
            this.serviceID = serviceID;
            this.serviceName = serviceName;
            this.price = price;
            this.unitID = unitID;
            this.note = note;
        }

        private void fEditService_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsUnits.Units' table. You can move, or remove it, as needed.
            this.unitsTableAdapter.Fill(this.dsUnits.Units);
            txtID.Enabled = false;
            txtID.Text = serviceID;
            txtServiceName.Text = serviceName;
            txtPrice.Text = price;
            rtbNote.Text = note;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string serviceID = txtID.Text;
            string serviceName = txtServiceName.Text;
            string unitId = cbUnits.SelectedValue.ToString();
            string price = txtPrice.Text;
            string note = rtbNote.Text;

            try
            {
                _ = Controllers.ServiceController.UpdateService(serviceID, serviceName, unitId, price, note);
                MessageBox.Show("Sửa thành công");
                this.Close();
            }
            catch
            { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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