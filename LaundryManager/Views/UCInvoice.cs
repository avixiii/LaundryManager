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
    public partial class UCInvoice : System.Windows.Forms.UserControl
    {
        public UCInvoice()
        {
            InitializeComponent();
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            bool flag = true;

            gcInvoice.Dock = DockStyle.Bottom;

            if (flag == true)
            {
                panelCreateBill.Controls.Clear();
                UCCreateBill ucCreateBill = new UCCreateBill();
                
                ucCreateBill.Height = 600;
                panelCreateBill.Dock = DockStyle.Top;
                gcInvoice.Height = gcInvoice.Height - 500;
                panelCreateBill.Controls.Add(ucCreateBill);
                btnCreateInvoice.Enabled = false;
                btnEdit.Enabled = false;
                btnPrint.Enabled = false;
                btnIgnore.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            panelCreateBill.Controls.Clear();
            gcInvoice.Dock = DockStyle.Fill;
            btnCreateInvoice.Enabled = true;
            btnIgnore.Enabled = false;
            btnEdit.Enabled = true;
            btnPrint.Enabled = true;
        }

        private void UCInvoice_Load(object sender, EventArgs e)
        {
            btnIgnore.Enabled = false;
        }
    }
}
