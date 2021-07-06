using DevExpress.XtraEditors;
using LaundryManager.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaundryManager
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check ô đăng nhập có dữ liệu không
            if (txtUsername.Text == "")
            {
                XtraMessageBox.Show("Tên đăng nhập không được để trống");
                return;
            }
            else
            {
                if (txtPassword.Text == "")
                {
                    XtraMessageBox.Show("Mật khẩu không được để trống.");
                    return;
                }
            }

            // Có data trong ô textbox 
            string check = "";
            string user = txtUsername.Text.Trim();
            string pass = Models.UserControl.SHA256(txtPassword.Text);
            check = Controllers.UserController.CheckLogin(user, pass);

            if (check == "")
            {
                XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }  
            else
            {
                string checkStatus = "";
                checkStatus = Controllers.UserController.CheckStatus(user, pass);
                if (checkStatus == "")
                {
                    MessageBox.Show("Tài khoản của bạn chưa được ACTIVE\nXin vui lòng liên hệ với quản trị viên");
                }
                else
                {
                    fLaunryManager fLaunry = new fLaunryManager(user);
                    this.Hide();
                    fLaunry.ShowDialog();
                    this.Close();
                }    
                
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát chương trình? ", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialog == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}
