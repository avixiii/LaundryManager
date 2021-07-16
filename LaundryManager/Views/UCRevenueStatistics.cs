using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManager.Views
{
    public partial class UCRevenueStatistics : DevExpress.XtraEditors.XtraUserControl
    {
        public UCRevenueStatistics()
        {
            InitializeComponent();
        }

        private void UCRevenueStatistics_Load(object sender, EventArgs e)
        {
            ShowUnpaid();
            ShowPaid();

        }

        // Hiển thị danh sách khách hàng chưa thanh toán hoá đơn
        public void ShowUnpaid()
        {
            gcUnpaid.DataSource = Controllers.StatisticsController.FillDataSetUnpaid();
            gvUnpaid.GroupPanelText = " ";
            gcUnpaid.DataMember = "Bills";
            lblUnpaid.Text =  Total(gvUnpaid).ToString() + " đồng";
        }
        // Hiển thị danh sách khách hàng đã thanh toán hoá đơn
        public void ShowPaid()
        {
            gcPaid.DataSource = Controllers.StatisticsController.FillDataSetPaid(); ;
            gvPaid.GroupPanelText = " ";
            gcPaid.DataMember = "Bills";
            
            lblPaid.Text = Total(gvPaid).ToString() + " đồng";
        }

        private string Total(GridView view)
        {
            double total = 0;
            for (int i = 0; i < view.DataRowCount; i++)
            {
                // lay gia
                double totalBill = double.Parse(view.GetRowCellValue(i, "Total").ToString());
                total += totalBill;
            }

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            string a = double.Parse(total.ToString()).ToString("#,###", cul.NumberFormat);

            return a;
        }
    }
}
