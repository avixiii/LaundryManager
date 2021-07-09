using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Models
{
    class InvoiceModel
    {
        public static DataSet FillDataSetInvoice()
        {

            return Models.Connection.FillDataSet("spgetBills", CommandType.StoredProcedure);
        }
    }
}
