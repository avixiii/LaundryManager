using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections;
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
    public partial class fCreateBill : DevExpress.XtraEditors.XtraForm
    {
        public fCreateBill()
        {
            InitializeComponent();
            sqlDataSource1.FillAsync();
            txtTotal.Text = TotalPriceInCart().ToString();
            txtTotal.Text = TotalBill().ToString();
        }

        private void fCreateBill_Load(object sender, EventArgs e)
        {
            gcCart.DataSource = SampleDS();
            txtBillCode.Text = Models.Connection.ExcuteScalar(String.Format("SELECT dbo.fcgetBillCode()"));
        }

        BindingList<BillDetails> ds = new BindingList<BillDetails>();
        public BindingList<BillDetails> SampleDS()
        {
            
            return ds;
        }
        
        public class BillDetails
        {
            public string ServID { get; set; }
            public string ServiceNameBD { get; set; }
            public Int32 Quantity { get; set; }
            public double Total { get; set; }

            public BillDetails()
            {
            }

            public BillDetails(string serviceID, string serviceName, int quantity, double total)
            {
                ServID = serviceID;
                ServiceNameBD = serviceName;
                Quantity = quantity;
                Total = total;
            }
        }

        IDictionary<string, int> serviceList = new Dictionary<string, int>();
        private void ribtnAdd_Click(object sender, EventArgs e)
        {
            object value;
            int rowIndex = gvServiceList.FocusedRowHandle;

            // Lấy id
            string colFieldID = "ID";
            value = gvServiceList.GetRowCellValue(rowIndex, colFieldID);
            string serviceID = value.ToString();

            // Lấy tên
            string colFieldName = "ServiceName";
            value = gvServiceList.GetRowCellValue(rowIndex, colFieldName);
            string serviceName = value.ToString();

            // Lấy đơn giá
            string colFieldPrice = "Price";
            value = gvServiceList.GetRowCellValue(rowIndex, colFieldPrice);
            string s = value.ToString();
            double price = double.Parse(s);

            /*
             Them vao cart

            - Kiem tra xem ton tai trong gvCart chua
            - TON TAI: QUANTITY ++
            - KHONG TON TAI : ADD NEW ROW
             */


            // check xem tco trong gvCart chua

            bool flg = false;

            for (int i = 0; i < gvCart.DataRowCount; i++)
            {
                string servID = gvCart.GetRowCellValue(i, "ServID").ToString();
                if (servID == serviceID)
                {
                    flg = true;
                }
            }
            if (flg)
            {
                for (int i = 0; i < gvCart.DataRowCount; i++)
                {
                    string servID = gvCart.GetRowCellValue(i, "ServID").ToString();
                    if (serviceID == servID)
                    {
                        // Lay so luong - Tang quantity len 1
                        int quantity = int.Parse(gvCart.GetRowCellValue(i, "Quantity").ToString());
                        ++quantity;
                        gvCart.SetRowCellValue(i, "Quantity", quantity);
                        gvCart.SetRowCellValue(i, "Total", quantity * price);
                        txtTotal.Text = TotalPriceInCart().ToString();
                        txtTotal1.Text = TotalBill().ToString();

                    }
                }

            }
            else
            {
                int count = gvCart.DataRowCount;
                gvCart.AddNewRow();
                gvCart.DeleteRow(gvCart.RowCount);
                gvCart.SetRowCellValue(count, "ServID", serviceID);
                gvCart.SetRowCellValue(count, "ServiceName", serviceName);
                gvCart.SetRowCellValue(count, "Quantity", 1);
                gvCart.SetRowCellValue(count, "Total", price);

                txtTotal.Text = TotalPriceInCart().ToString();
                txtTotal1.Text = TotalBill().ToString();
            }

        }

        private void riBtnDelete_Click(object sender, EventArgs e)
        {
            gvCart.DeleteRow(gvCart.FocusedRowHandle);
            txtTotal.Text = TotalPriceInCart().ToString();
            txtTotal1.Text = TotalBill().ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string billCode = txtBillCode.Text;

            string strBillDate = dtBillDate.Text;
            DateTime billDate = DateTime.Parse(strBillDate);

            string strAppointmentDate = dtAppointmentDate.Text;
            DateTime appointmentDate = DateTime.Parse(strAppointmentDate);

            string customerName = txtCustomerName.Text;
            string phone = txtPhone.Text;

            string address = txtAddress.Text;

            string total = txtTotal.Text; // Tiền khi chưa chiết khẩu

            string strDiscount = txtDiscount.Text;
            double discount = double.Parse(strDiscount);

            string strSurcharge = txtSurcharge.Text;
            if (strSurcharge == "")
            {
                strSurcharge = "0";
            }    
            double surcharge = double.Parse(strSurcharge);

            string strTotal1 = txtTotal1.Text; // Tiền sau khi đã chiết khẩu
            double total1 = double.Parse(strTotal1);

            string note = txtNote.Text;


            int userID = fLogin.userID;
            // INSERT CUSTOMER
            Controllers.CustomerController.InsertCustomer(customerName, address, phone, total1);


            // Lấy id Customer vừa thêm vào
            int cusID = Controllers.CustomerController.GetID();
            // INSERT BILL
            string s = txtDiscount.Text;
            double d;
            try
            {
                d = double.Parse(s);
            }
            catch
            {
                d = 100;
            }
            double discountMoney = TotalPriceInCart() * (discount / 100.0);

            Controllers.BillsController.InsertBill(billCode, cusID, userID, billDate, appointmentDate, discountMoney, surcharge, note, total1);

            // INSERT BILLDETAILS - 1. Lấy các row trong gcCart - 2. Insert lần lượt vào trong db

            for (int i = 0; i < gvCart.DataRowCount; i++)
            {
                // Lấy servID, quantity , total , : price = total / quantity
                object value;
                value = gvCart.GetRowCellValue(i, "ServID");
                string servID = (string)value;

                // Quantity
                value = gvCart.GetRowCellValue(i, "Quantity");
                int quantity = (int)value;


                // Price 
                value = gvCart.GetRowCellValue(i, "Total");
                double totalBillDetails = (double)value;
                double pricez = totalBillDetails / quantity;

                Controllers.BillDetailsController.InsertBillDetails(billCode, servID, quantity, pricez, totalBillDetails);
            }
            this.Close();

       //     

        }

        private void riBtnRemove_Click(object sender, EventArgs e)
        {
            int rowIndex = gvCart.FocusedRowHandle;
            int quantity = int.Parse(gvCart.GetRowCellValue(rowIndex, "Quantity").ToString());
            double totalServiceCost = double.Parse(gvCart.GetRowCellValue(rowIndex, "Total").ToString());


            double servPrice = totalServiceCost / quantity; // Đơn giá của dịch vụ
            --quantity;
            gvCart.SetRowCellValue(rowIndex, "Quantity", quantity);
            gvCart.SetRowCellValue(rowIndex, "Total", totalServiceCost - servPrice);

            txtTotal.Text = TotalPriceInCart().ToString();
            txtTotal1.Text = TotalBill().ToString();

            // Xoá sản phẩm khỏi gvCart
            if (quantity == 0)
            {
                gvCart.DeleteRow(gvCart.FocusedRowHandle);
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = TotalPriceInCart().ToString();
            txtTotal1.Text = TotalBill().ToString();
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

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSurcharge_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSurcharge_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = TotalPriceInCart().ToString();
            txtTotal1.Text = TotalBill().ToString();
        }

        private double TotalBill()
        {
            double total = 0;

            double totalServiceCost = double.Parse(txtTotal.Text.ToString());
            string value;
            value = txtDiscount.Text.ToString();

            if (value == "")
            {
                value = "0";
            }
            double discount = double.Parse(value);

            value = txtSurcharge.Text.ToString();
            if (value == "")
            {
                value = "0";
            }
            double surcharge = double.Parse(value);

            total = totalServiceCost - (totalServiceCost * (discount) / 100) + surcharge;


            return total;
        }

        private double TotalPriceInCart()
        {
            double totalPriceInCart = 0;
            for (int i = 0; i < gvCart.DataRowCount; i++)
            {
                // lay gia
                double totalServiceCost = double.Parse(gvCart.GetRowCellValue(i, "Total").ToString());
                totalPriceInCart += totalServiceCost;
            }
            return totalPriceInCart;
        }


    }
}