using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Controllers
{
    class CustomerController
    {

        // Insert
        public static int InsertCustomer(string name, string address, string phone, double totalBill)
        {
            try
            {
                Models.CustomerModel insertCustomer = new Models.CustomerModel(name, address, phone, totalBill);
                return insertCustomer.InsertCustomer();
            }
            catch
            {
                return 0;
            }
        }

        public static int GetID()
        {
            try
            {
                Models.CustomerModel getID = new Models.CustomerModel();
                return getID.GetID();
            }
            catch { return 1; }
        }
    }
}
