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
    public partial class fBackup : DevExpress.XtraEditors.XtraForm
    {
        public fBackup()
        {
            InitializeComponent();
        }
        XtraFolderBrowserDialog fd;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            fd = new XtraFolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fd.SelectedPath.ToString();
            }    
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text;
            string fileName = txtFileName.Text;

            try
            {
                Controllers.DataController.Backup(path, fileName);
                MessageBox.Show("BACKUP THÀNH CÔNG");
                this.Close();
            }
            catch
            {
                MessageBox.Show("BACKUP THẤT BẠI , VUI LÒNG KIỂM TRA LẠI HOẶC LIÊN HẸ VỚI NHÀ PHÁT TRIỂN");
            }
            
        }
    }
}