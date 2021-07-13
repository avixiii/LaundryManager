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

            // Mã hoá pass
            pass = Models.UserControl.SHA256(pass);
            // Check username tồn tại chưa ? 
            string check = "";
            check = Controllers.UserController.CheckUser(user);

            if (check != "") // Tồn tại user 
            {
                MessageBox.Show("Tài khoản đã được sử dụng, xin vui lòng nhập tên tài khoản kh");
            }
            else // Không tồn tại
            {
                Controllers.UserController.SignUp(user, pass, fullName, phone, address, birthDay, idCard, status);
                this.Close();
            }
            
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Tên tài khoản không được để trống.");
            }    
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Mật khẩu không được để trống.");
            }
        }
    }
}