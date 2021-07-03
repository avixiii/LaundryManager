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
    public partial class fAddUnits : DevExpress.XtraEditors.XtraForm
    {
        public fAddUnits()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAddUnits_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtID.Text = Models.Connection.ExcuteScalar(String.Format("SELECT dbo.fcgetUnitID()"));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string unitID = txtID.Text;
            string unit = txtUnitName.Text;
            string note = txtNote.Text;

            if (unit == "")
            {
                MessageBox.Show("Tên đơn vị không được để trống.");
            }
            else
            {
                
            try
            {
                    _ = Controllers.UnitController.InsertUnit(unitID, unit, note);
                    MessageBox.Show("Thêm thành công");
                    this.Close();
            }
            catch
            { }
            }    
        }
    }
}