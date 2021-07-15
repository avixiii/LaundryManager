using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Controllers
{
    class BillDetailsController
    {
        public static int InsertBillDetails(string billCode, string servID, int quantity, double price, double total)
        {
            try
            {
                Models.BillDetailsModel billDetails = new Models.BillDetailsModel(billCode, servID, quantity, price, total);
                return billDetails.InsertBillDetails();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateBillDetails(string billCode, string servID, int quantity, double price, double total)
        {
            try
            {
                Models.BillDetailsModel billDetails = new Models.BillDetailsModel(billCode, servID, quantity, price, total);
                return billDetails.UpdateBillDetails();
            }
            catch
            {
                return 0;
            }
        }

        public static int DeleteBillDetails(string billCode, string servID)
        {
            try
            {
                Models.BillDetailsModel delete = new Models.BillDetailsModel(billCode, servID);
                return delete.DeleteBillDetails();
            }
            catch
            {
                return 0;
            }
        }

        public static DataSet FillDataSetCart(string billCode)
        {
            DataSet ds = null;
            try
            {
                Models.BillDetailsModel cart = new Models.BillDetailsModel(billCode);
                return cart.FillDataSetCart();
            }
            catch
            { return ds; }
        }
    }
}
