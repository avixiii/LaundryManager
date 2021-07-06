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
    public partial class fSignUp : DevExpress.XtraEditors.XtraForm
    {
        public fSignUp()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            string fullName = txtFullName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string birthDay = dtBirthday.Text;
            string idCard = txtIDCard.Text;
            bool status;
            if (ckbStatus.Checked == true)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            // 
            if (user == "")
            {
                MessageBox.Show("Tài khoản không được để trống.");
            }
            if (pass == "")
            {
                MessageBox.Show("Mật khẩu không được để trống.");
            }    

            // Mã hoá pass
            pass = Models.UserControl.SHA256(pass);
            // Check username tồn tại chưa ? 
            string check = "";
            check = Controllers.UserController.CheckUser(user);

            if (check != "") // Tồn tại user 
            {
                MessageBox.Show("Tên tài khoản đã được sử dụng xin vui lòng nhập tên khác");
            }
            else // Không tồn tại
            {
                int i = 0;

                try
                {
                    i = Controllers.UserController.SignUp(user, pass, fullName, phone, address, birthDay, idCard, status);
                    MessageBox.Show("Đăng ký thành công.");
                   
                }
                catch { }
                finally
                { this.Close(); }
            }  

        }
    }
}