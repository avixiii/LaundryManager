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
    public partial class UCFinancialManagement : DevExpress.XtraEditors.XtraUserControl
    {
        public UCFinancialManagement()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            fCreateFinancialInvoice fCreateFI = new fCreateFinancialInvoice();
            fCreateFI.ShowDialog();
        }

        private void ckbID_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbID.Checked)
            {
                txtID.Enabled = true;
                btnSearchByID.Enabled = true;
            }
            else
            {
                txtID.Enabled = false;
                btnSearchByID.Enabled = false;
            }
        }

        private void ckbEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEmployee.Checked)
            {
                txtEmployee.Enabled = true;
            }
            else
            {
                ckbEmployee.Enabled = false;
            }    
        }

        private void ckbBillType_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBillType.Checked)
            {
                cbBillType.Enabled = true;
            }    
            else
            {
                cbBillType.Enabled = false;
            }    
           
        }

        private void ckbTime_CheckedChanged(object sender, EventArgs e)
        {
           if (ckbTime.Checked)
            {
                dtTime.Enabled = true;
            }
           else
            {
                dtTime.Enabled = false;
            }    
        }

        private void ckbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDate.Checked)
            {
                dt1.Enabled = true;
                dt2.Enabled = true;
            }    
            else
            {
                dt1.Enabled = false;
                dt2.Enabled = false;
            }    
        }
    }
}
