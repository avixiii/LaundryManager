using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Controllers
{
    class CashBookController
    {
        public static int Insert(string id, int userID, string billType, DateTime billDate, string payer, double amount, string reason, string explain)
        {
            try
            {
                Models.CashBookModel insert = new Models.CashBookModel(id, userID, billType, billDate, payer, amount, reason, explain);
                return insert.Insert();
            }
            catch { return 0; }
        }

        public static int Update(string id, int userID ,string billType, DateTime billDate, string payer, double amount, string reason, string explain)
        {
            try
            {
                Models.CashBookModel update = new Models.CashBookModel(id, userID , billType, billDate, payer, amount, reason, explain);
                return update.Update();
            }
            catch { return 0; }
        }
    
        public static int Delete(string id)
        {
            try
            {
                Models.CashBookModel insert = new Models.CashBookModel(id);
                return insert.Delete();
            }
            catch { return 0; }
        }
    }
}
