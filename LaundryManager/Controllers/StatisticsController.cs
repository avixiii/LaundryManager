using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Controllers
{
    class StatisticsController
    {
        public static DataSet FillDataSetUnpaid()
        {
            DataSet ds = null;
            try
            {
                Models.StatisticsModel unpaid = new Models.StatisticsModel();
                return unpaid.FillDataSetUnpaid();
            }
            catch
            { return ds; }
        }

        public static DataSet FillDataSetPaid()
        {
            DataSet ds = null;
            try
            {
                Models.StatisticsModel unpaid = new Models.StatisticsModel();
                return unpaid.FillDataSetPaid();
            }
            catch
            { return ds; }
        }
    }
}
