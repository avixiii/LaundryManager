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
    public partial class fChangePass : DevExpress.XtraEditors.XtraForm
    {
        public fChangePass()
        {
            InitializeComponent();
        }
        private string user;

        public fChangePass(string _user):this()
        {
            user = _user;
        }
        

        private void fChangePass_Load(object sender, EventArgs e)
        {
            lbUserName.Text = user;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string oldPass = Models.UserControl.SHA256(txtOldPass.Text);
            string newPass = txtNewPass.Text;
            string newPass2 = txtNewPass2.Text;

  

            if (newPass != newPass2)
            {
                MessageBox.Show("Mật khẩu phải giống nhau. xin vui lòng kiểm tra lại.");
            }
            else
            {
                // Validate
                if (newPass == "")
                {
                    MessageBox.Show("Mật khẩu mới không được để trống.");
                }
                else
                {
                    // check pass cũ
                    string check = Controllers.LoginController.CheckLogin(lbUserName.Text, oldPass);
                    if (check == "")
                    {
                        MessageBox.Show("Pass cu sai");
                    }
                    else
                    {
                        try
                        {
                            _ = Controllers.LoginController.ChangePass(lbUserName.Text, Models.UserControl.SHA256(newPass));
                            MessageBox.Show("Đổi pass thành công");
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("ERR");
                        }
                    }
                } 
            }    
        }
    }
}