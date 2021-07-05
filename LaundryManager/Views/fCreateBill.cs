﻿using DevExpress.XtraEditors;
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
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }

        private void fCreateBill_Load(object sender, EventArgs e)
        {
            gcCart.DataSource = SampleDS();
        }

        public BindingList<BillDetails> SampleDS()
        {
            BindingList<BillDetails> ds = new BindingList<BillDetails>();
            return ds;
        }

        public class BillDetails
        {
            public string ServiceNameBD { get; set; }
            public Int32 Quantity { get; set; }
            public string Total { get; set; }

            public BillDetails()
            {
            }

            public BillDetails(string serviceName, int quantity, string total)
            {
                ServiceNameBD = serviceName;
                Quantity = quantity;
                Total = total;
            }
        }

        Hashtable serviceList = new Hashtable(); // 

        private void ribtnAdd_Click(object sender, EventArgs e)
        {
            object value;

            int rowIndex = gvServiceList.FocusedRowHandle;

            // Lấy tên
            string colFieldName = "ServiceName";
            value = gvServiceList.GetRowCellValue(rowIndex, colFieldName);
            string serviceName = value.ToString();

            bool flag = false;
            // Check xem có trong gvCart chưa 
            foreach (DictionaryEntry item in serviceList)
            {
                var key = item.Key;
                if (key.ToString() == serviceName)
                {
                    flag = true;
                    break;
                }    
            }
            
            if (flag == false) // dịchv vụ chưa thêm vào cart
            {
                // Khởi tạo số lượng đầu
                

                // Thêm vào trong hash id,  quantity 
                serviceList.Add(serviceName, 1);
                gvCart.AddNewRow();

                // Tính giá
                string colFieldPrice = "Price";
                value = gvServiceList.GetRowCellValue(rowIndex, colFieldPrice);
                string total = value.ToString();

                gvCart.SetRowCellValue(GridControl.NewItemRowHandle, "ServiceNameBD", serviceName);
                gvCart.SetRowCellValue(GridControl.NewItemRowHandle, "Quantity", 1);
                gvCart.SetRowCellValue(GridControl.NewItemRowHandle, "Total", total);
            }
            else
            {
                string colFieldNameBD = "ServiceNameBD";
                for (int i = 0; i < gvCart.DataRowCount; i++)
                {
                   
                    value = gvCart.GetRowCellValue(i, colFieldNameBD);
                    string serNameBD = value.ToString();
                    if (serviceName == serNameBD)
                    {
                        gvCart.SetRowCellValue(i, "Quantity", 2);
                    }
                    else
                    {

                    }    

                }
            }    

            
        }

        private void riBtnDelete_Click(object sender, EventArgs e)
        {
            gvCart.DeleteRow(gvCart.FocusedRowHandle);

            int rowIndex = gvCart.FocusedRowHandle;
            string colFieldName = "ServiceNameBD";
            object value = gvCart.GetRowCellValue(rowIndex, colFieldName);
            string str = (string)value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string billCode = txtBillCode.Text;
            string billDate = dtBillDate.Text;
            string appointmentDate = dtAppointmentDate.Text;
            string customerName = txtCustomerName.Text;
            string phone = txtPhone.Text;
            string total = txtTotal.Text; // Tiền khi chưa chiết khẩu
            string discount = txtDiscount.Text;
            string total1 = txtTotal1.Text; // Tiền sau khi đã chiết khẩu
            string status = cbStatus.GetItemText(cbStatus.SelectedItem);

            MessageBox.Show(status);
            
           
        }
    }
}