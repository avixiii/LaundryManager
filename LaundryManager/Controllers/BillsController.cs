using System;
using System.Collections.Generic;
using System.Data;
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
        public static int UpdateBill(string billCode, int userID, DateTime billDate, DateTime appointmentDate, double discount, double surcharget, string note, double total, string status)
        {
            try
            {
                Models.BillsModel update = new Models.BillsModel(billCode, userID, billDate, appointmentDate, discount, surcharget, note, total, status);
                return update.UpdateBill();
            }
            catch
            { return 0; }
        }


        // UPDATE STATUS
        public static int UpdateStatus(string billCode, string status)
        {
            try
            {
                Models.BillsModel updateStatus = new Models.BillsModel(billCode, status);
                return updateStatus.UpdateStatus();
            }
            catch
            {
                return 0;
            }
        }

        // PAYMENT

        public static int Payment(string billCode, double paid, double mustBePaid)
        {
            try
            {
                Models.BillsModel payment = new Models.BillsModel(billCode, paid, mustBePaid);
                return payment.Payment();
            }
            catch
            {
                return 0;
            }
        }

        // Delete
        public static int Delete(string billCode)
        {
            try
            {
                Models.BillsModel delete = new Models.BillsModel(billCode);
                return delete.Delete();
            }
            catch
            {
                return 0;
            }
        }

        public static DataTable GetInfo(string billCode)
        {
            try
            {
                Models.BillsModel getInfo = new Models.BillsModel(billCode);
                return getInfo.GetInfo();
            }
            catch
            {
                return null;
            }
        }

        // ID Customer 
        public static int GetCusID(string billCode)
        {
            try
            {
                Models.BillsModel getID = new Models.BillsModel(billCode);
                return getID.GetCusID();
            }
            catch { return 1; }
        }
    }
}
