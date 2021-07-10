﻿using DevExpress.XtraEditors;
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

       
        public void ShowInvoice()
        {
            cbStatus.Text = "-- Lựa chọn --";
            gcInvoice.DataSource = Models.InvoiceModel.FillDataSetInvoice() ;
            gcInvoice.DataMember = "Bills";

        }

        private void riBtnStatus_Click(object sender, EventArgs e)
        {
            fBillStatus status = new fBillStatus();
            status.ShowDialog();
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
                txtEmployee.Enabled = false;
            }
        }

        private void ckbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCustomer.Checked)
            {
                txtCustomer.Enabled = true;
            }
            else
            {
                txtCustomer.Enabled = false;
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

        private void ckbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbStatus.Checked)
            {
                cbStatus.Enabled = true;
            }
            else
            {
                cbStatus.Enabled = false;
            }
        }
    }
}
