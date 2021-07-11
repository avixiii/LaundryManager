using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Controllers
{
    class BillsController
    {

        // Insert
        public static int InsertBill(string billCode, int cusID, int userID, DateTime billDate, DateTime appointmentDate, double discount, double surcharget, string note, double total)
        {
            try
            {
                Models.BillsModel bill = new Models.BillsModel(billCode, cusID, userID, billDate, appointmentDate, discount, surcharget, note, total);
                return bill.InsertBill();
            }
            catch
            { return 0; }
        }

        // Update

        // Delete



    }
}
