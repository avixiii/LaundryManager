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

        }
    }
}