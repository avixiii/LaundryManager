using DevExpress.XtraEditors;
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
    public partial class UCCashBookReport : DevExpress.XtraEditors.XtraUserControl
    {
        public UCCashBookReport()
        {
            InitializeComponent();
            chart1.Titles.Add("Biểu đồ.");
            chart1.Series["Series1"].IsValueShownAsLabel = false;
            chart1.Series["Series1"].Points.AddXY("", UCCashBook.tienThu.ToString());
            chart1.Series["Series1"].Points[0].LegendText = "Tiền thu từ dịch vụ khác";
            chart1.Series["Series1"].Points.AddXY("", UCCashBook.tienChi.ToString());
            chart1.Series["Series1"].Points[1].LegendText = "Tiền chi";
            chart1.Series["Series1"].Points.AddXY("", UCRevenueStatistics.unPaid.ToString());
            chart1.Series["Series1"].Points[2].LegendText = "Tiền Chưa thu từ dịch vụ giặt ủi";
            chart1.Series["Series1"].Points.AddXY("", UCRevenueStatistics.paid.ToString());
            chart1.Series["Series1"].Points[3].LegendText = "Tiền đã thu từ dịch vụ giặt ủi";
        }

        private void UCCashBookReport_Load(object sender, EventArgs e)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"

            lblTienThu.Text = UCCashBook.tienThu.ToString();

            lblTienThu.Text = double.Parse(UCCashBook.tienThu.ToString()).ToString("#,###", cul.NumberFormat) + " VNĐ";
            lblTienChi.Text = double.Parse(UCCashBook.tienChi.ToString()).ToString("#,###", cul.NumberFormat) + " VNĐ";

            lblChuaThuTuGiatUi.Text = double.Parse(UCRevenueStatistics.unPaid.ToString()).ToString("#,###", cul.NumberFormat) + " VNĐ";
            lblThuTuDvGiatUi.Text = double.Parse(UCRevenueStatistics.paid.ToString()).ToString("#,###", cul.NumberFormat) + " VNĐ";

            
            lblTotal.Text = double.Parse(((UCCashBook.tienThu + UCRevenueStatistics.paid) - UCCashBook.tienChi).ToString()).ToString("#,###", cul.NumberFormat) + " VNĐ";
        }
    }
}
