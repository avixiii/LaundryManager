using DevExpress.XtraBars;
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
    public partial class fLaunryManager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public fLaunryManager()
        {
            InitializeComponent();
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult _dialog = MessageBox.Show("Bạn có muốn thoát chương trình? ", "Thông báo!", MessageBoxButtons.YesNoCancel);
            if (_dialog == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btnInvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            UCInvoice ucInvoice = new UCInvoice();
            ucInvoice.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ucInvoice);
        }

        private void btnServicePriceList_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            UCServicePriceList ucServicePriceList = new UCServicePriceList();
            ucServicePriceList.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ucServicePriceList);
        }
    }
}