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
    public partial class fEditBill : DevExpress.XtraEditors.XtraForm
    {

        List<string> getServIdBefore;
        public fEditBill()
        {
            InitializeComponent();
            LoadData();
            getServIdBefore = GetServId();
        }

        // 1. Lấy mã dịch vụ trong gvCart
        public List<string> GetServId()
        {
            List<string> listID = new List<string>();

            for (int i = 0; i < gvCart.DataRowCount; i++)
            {
                string servID = gvCart.GetRowCellValue(i, "ServID").ToString();
                listID.Add(servID);
            }
            return listID;
        }



        private string billCode = UCInvoice.id;

        private void riBtnAdd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

            for (int i = 0 ; i < gvCart.DataRowCount; i++)
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


        public void LoadData()
        {
            sqlDataSource1.FillAsync();
            gcCart.DataSource = Controllers.BillDetailsController.FillDataSetCart(billCode);
            gcCart.DataMember = "Cart";
            txtBillCode.Text = billCode;
            txtTotal.Text = TotalPriceInCart().ToString();
            txtTotal1.Text = TotalBill().ToString();
            LoadInfo();
        }

        // Load info

        public void LoadInfo()
        {
            DataTable info = Controllers.BillsController.GetInfo(billCode);
            // SELECT Status, BillDate, AppointmentDate, Name, Phone, Discount, Total, Surcharge, Address, NOTE FROM dbo.Bills, dbo.Customers WHERE CusID = ID AND BillCode = @BillCode

            var status = info.Rows[0][0];
            cbStatus.Text = status.ToString();

            var billDate = info.Rows[0][1];
            dtBillDate.Text = billDate.ToString();

            var appointmentDate = info.Rows[0][2];
            dtAppointmentDate.Text = appointmentDate.ToString();

            var name = info.Rows[0][3];
            txtCustomerName.Text = name.ToString();

            var phone = info.Rows[0][4];
            txtPhone.Text = phone.ToString();


            var total = info.Rows[0][6];
            txtTotal1.Text = total.ToString();

            var surcharge = info.Rows[0][7];
            txtSurcharge.Text = surcharge.ToString();

            double discountPrice = double.Parse(info.Rows[0][5].ToString());

            double x = double.Parse(txtTotal.Text.ToString());
            double discount = (discountPrice * 100) / (double.Parse(total.ToString()) - double.Parse(surcharge.ToString()) + discountPrice);
            txtDiscount.Text = discount.ToString();

            var address = info.Rows[0][8];
            txtAddress.Text = address.ToString();

            var note = info.Rows[0][9];
            txtNote.Text = note.ToString();
        }


        // Xoa san pham khoi gvCart
        private void riBtnDelete_Click(object sender, EventArgs e)
        {
            gvCart.DeleteRow(gvCart.FocusedRowHandle);
            txtTotal.Text = TotalPriceInCart().ToString();
            txtTotal1.Text = TotalBill().ToString();
        }

        // Giảm số lượng sản phẩm trong gvCart
        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
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
            string status = cbStatus.GetItemText(cbStatus.SelectedItem);


            int userID = fLogin.userID;
            // Lay id cusID bill
            int cusID = Controllers.BillsController.GetCusID(billCode);

            // UPDATE CUSTOMER
            Controllers.CustomerController.UpdateCustomer(cusID, customerName, address, phone, total1);

            // UPDATE BILL
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
            double discountMoney = double.Parse(total) * (discount / 100.0);

            Controllers.BillsController.UpdateBill(billCode, userID, billDate, appointmentDate, discountMoney, surcharge, note, total1, status);


            // Lấy danh sách mã dịch vụ sau khi chỉnh sửa.
            List<string> getServIdAfter = GetServId();

            /*
            So sánh id trong list trước khi chỉnh sửa với list đã chỉnh sửa
            - Nếu trùng : Update
            - Nếu list id trước khi chỉnh sửa không còn tồn tại id nào giống trong list id sau khi chỉnh sửa: => Xoá BillDetails có id đó đi
            - Nếu list sau khi chỉnh sửa có id khác với id trong list id trước khi chỉnh sửa thì insert nó vào.
             */
            
            // Lấy ra id trùng
            List<string> listID = new List<string>();

            if (getServIdAfter.Count() > getServIdBefore.Count())
            {
                foreach (string i in getServIdAfter)
                {
                    foreach(string j in getServIdBefore)
                    {
                        if (i == j)
                        {
                            listID.Add(i);
                        }
                    }    
                }    
            }
            else
            {
                foreach (string i in getServIdBefore)
                {
                    foreach (string j in getServIdAfter)
                    {
                        if (i == j)
                        {
                            listID.Add(i);
                        }
                    }
                }
            }

            // Lấy id không có trong list đầu tiên
            List<string> listID1 = new List<string>(); // dùng lưu id mới ko có trong list đầu; do hết tên biến để đặt rùi nên đặt v, hic

            if (getServIdAfter.Count() > getServIdBefore.Count())
            {
                bool check = true;
                foreach (string i in getServIdAfter)
                {
                    foreach (string j in getServIdBefore)
                    {
                        if (i == j)
                        {
                            check = true;
                            break;
                        }
                        check = false;
                    }
                    if (check == false)
                    {
                        listID1.Add(i);
                    }    
                }
            }
            else
            {
                bool check = true;
                foreach (string i in getServIdBefore)
                {
                    foreach (string j in getServIdAfter)
                    {
                        if (i == j)
                        {
                            check = true;
                            break;
                        }
                        check = false;
                    }
                    if (check == false)
                    {
                        listID1.Add(i);
                    }
                }
            }



            // Lấy id có trong list đầu và không có trong list 2 : để xoá 
            List<string> listID2 = new List<string>();

            bool _check = false;
            foreach (string i in getServIdBefore)
            {
                
                foreach(string j in getServIdAfter)
                {
                    if (i == j)
                    {
                        _check = true;
                        break;
                    }
                    _check = false;
                }
                if (_check == false)
                {
                    listID2.Add(i);
                }    
            }    


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
                double totalBillDetails = double.Parse(value.ToString());
                double pricez = totalBillDetails / quantity;

                // Update
                foreach(string id in listID)
                {
                    if (id == servID)
                    {
                        Controllers.BillDetailsController.UpdateBillDetails(billCode, servID, quantity, pricez, totalBillDetails);
                    }    
                }

                // Insert
                foreach(string id in listID1)
                {
                    if (id == servID)
                    {
                        Controllers.BillDetailsController.InsertBillDetails(billCode, servID, quantity, pricez, totalBillDetails);
                    }
                }    


                // Delete

                foreach(string id in listID2)
                {
                    Controllers.BillDetailsController.DeleteBillDetails(billCode, id);
                }    

                

            }
            this.Close();
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

            total = totalServiceCost - (totalServiceCost * (discount)/100) + surcharge;

           
            return total;
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            txtTotal1.Text = TotalBill().ToString();
        }

        private void txtSurcharge_TextChanged(object sender, EventArgs e)
        {
            txtTotal1.Text = TotalBill().ToString();
        }

    }
}