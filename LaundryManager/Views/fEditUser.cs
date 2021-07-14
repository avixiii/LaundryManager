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
    public partial class fEditUser : DevExpress.XtraEditors.XtraForm
    {
        public fEditUser()
        {
            InitializeComponent();
        }

        private string user;
        private string fullName;
        private string phone;
        private string address;
        private DateTime birthDay;
        private string idCard;
        private bool status;

        public fEditUser(string user, string fullName, DateTime birthDay,string phone, string address, string idCard, bool status): this()
        {
            this.user = user;
            this.fullName = fullName;
            this.phone = phone;
            this.address = address;
            this.birthDay = birthDay;
            this.idCard = idCard;
            this.status = status;
        }

        private void fEditUser_Load(object sender, EventArgs e)
        {
            txtUsername.Text = user;
            txtFullName.Text = fullName;
            txtPhone.Text = phone;
            txtAddress.Text = address;
            dtBirthday.DateTime = birthDay;
            ckbStatus.Checked = status;
            txtIDCard.Text = idCard;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string fullName = txtFullName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string birthDay = dtBirthday.Text;
            string idCard = txtIDCard.Text;
            bool status = ckbStatus.Checked;
            
            Controllers.UserController.Update(user, fullName, phone, address, birthDay, idCard, status);

            this.Close();
        }
    }
}