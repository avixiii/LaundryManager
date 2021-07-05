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

        public fEditUser(string _user, string _fullName, string _phone, string _address,string _idCard, bool _status)
        {
            user = _user;
            fullName = _fullName;
            phone = _phone;
            address = _address;
            idCard = _idCard;
            status = _status;
        }


        private string user;
        private string fullName;
        private string phone;
        private string address;
        private string idCard;
        private bool status;

        private void fEditUser_Load(object sender, EventArgs e)
        {
            txtUsername.Text = user;
            txtFullName.Text = fullName;
            txtPhone.Text = phone;
            txtAddress.Text = address;
            ckbStatus.Checked = status;
            txtIDCard.Text = idCard;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}