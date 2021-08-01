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

        public static double paid;
        public static double unPaid;
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
        // Hiển thị danh sách khách hàng chưa thanh toán hoá đơn
        public void ShowUnpaid()
        {
            gcUnpaid.DataSource = Controllers.StatisticsController.FillDataSetUnpaid();
            gvUnpaid.GroupPanelText = " ";
            gcUnpaid.DataMember = "Bills";
            lblUnpaid.Text = double.Parse(Total(gvUnpaid).ToString()).ToString("#,###", cul.NumberFormat) + " đồng";
            string flg;
            flg = Total(gvUnpaid).ToString();
            if(lblUnpaid.Text == "")
            {
                lblUnpaid.Text = "0";
                unPaid = 0;
            }
            else
            {
                unPaid = double.Parse(flg);
            }    
            
        }
        // Hiển thị danh sách khách hàng đã thanh toán hoá đơn
        public void ShowPaid()
        {
            gcPaid.DataSource = Controllers.StatisticsController.FillDataSetPaid(); ;
            gvPaid.GroupPanelText = " ";
            gcPaid.DataMember = "Bills";

            lblPaid.Text = double.Parse(Total(gvPaid).ToString()).ToString("#,###", cul.NumberFormat) + " đồng";
            string flg;
            flg = Total(gvPaid).ToString();
            if (flg == "")
            {
                flg = "0";
            }
             paid = double.Parse(flg);
        }

        private double Total(GridView view)
        {
            double total = 0;
            for (int i = 0; i < view.DataRowCount; i++)
            {
                // lay gia
                double totalBill = double.Parse(view.GetRowCellValue(i, "Total").ToString());
                total += totalBill;
            }

            return total;
        }
    }
}
