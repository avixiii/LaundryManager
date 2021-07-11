using System;
using System.Collections.Generic;
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
    }
}
