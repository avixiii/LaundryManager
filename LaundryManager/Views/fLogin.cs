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

        public static string username = "";
        public static int userID;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Remember
            if (ckbRemember.Checked == true)
            {
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();
            }
            if (ckbRemember.Checked == false)
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
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
            username = user;
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
                    // Lấy id user
                    userID = Controllers.UserController.GetID(user, pass);
                    // Mở form
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

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }
    }
}
