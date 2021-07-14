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
    public partial class UCCustomers : DevExpress.XtraEditors.XtraUserControl
    {
        public UCCustomers()
        {
            InitializeComponent();
            ShowCustomers();
        }

        public void ShowCustomers()
        {
            gcCustomers.DataSource = Models.CustomerModel.FillDataSetCustomers();
            gcCustomers.DataMember = "Customers";
            gvCustomers.ViewCaption = "Hoá đơn";
        }
    }
}
