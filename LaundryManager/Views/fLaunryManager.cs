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

        private string user;
        public fLaunryManager(string _user):this()
        {
            user = _user;
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

        private void btnChangePass_ItemClick(object sender, ItemClickEventArgs e)
        {
            fChangePass fChangePass = new fChangePass(user);
            fChangePass.ShowDialog();
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            fLogin fLogin = new fLogin();
            this.Hide();
            fLogin.ShowDialog();
            this.Close();
        }

        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            fBackup fBackup = new fBackup();
            fBackup.ShowDialog();
        }

        private void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            fRestore fRestore = new fRestore();
            fRestore.Show();
        }

        private void btnStoreInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("ĐÂY LÀ BÀI TẬP LỚN MÔN THỰC TẬP CHUYÊN NGÀNH 1\nHọ và tên: Phạm Anh Tuấn\nLớp: CNTT2-K10\nTrường: Đại học Công nghệ Đông Á\n\nPhần giới thiệu thông tin cửa hàng này sẽ được cập nhật update sau, để người dùng có thể chỉnh sửa.", "Thông báo");
        }

        private void btnSystemHistory_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng đang trong quá trình phát triển");
        }

        private void btnDecentralize_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng đang trong quá trình phát triển");
        }

        private void btnEmployeeList_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            UCUsers ucUsers = new UCUsers();
            ucUsers.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ucUsers);
        }

        private void btnCustomerList_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            UCCustomers uCCustomers = new UCCustomers();
            uCCustomers.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uCCustomers);
        }
    }
}