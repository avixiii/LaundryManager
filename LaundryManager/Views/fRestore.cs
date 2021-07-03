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
    public partial class fRestore : DevExpress.XtraEditors.XtraForm
    {
        public fRestore()
        {
            InitializeComponent();
        }

        XtraOpenFileDialog od;
        private void btnBrower_Click(object sender, EventArgs e)
        {
            od = new XtraOpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = od.SafeFileName.ToString();
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text;

            try
            {
                string check = Controllers.RestoreController.Restore(path);
                if (check !="")
                {
                    MessageBox.Show("RESTORE THÂT BẠI");
                    
                }
                else
                {
                    MessageBox.Show("RESTORE THÀNH CÔNG");
                }    
               
                this.Close();
            }
            catch
            {
                MessageBox.Show("RESTORE THẤT BẠI , VUI LÒNG KIỂM TRA LẠI HOẶC LIÊN HẸ VỚI NHÀ PHÁT TRIỂN");
            }
            finally
            {
                this.Close();
            }
        }
    }
}