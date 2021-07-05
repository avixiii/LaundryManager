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
            fCreateBills fCreateBills = new fCreateBills();
            fCreateBills.ShowDialog();
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
        }
    }
}
