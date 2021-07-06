using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Controllers
{
    class UnitController
    {
        public static int InsertUnit(string id, string unit, string note)
        {
            try
            {
                Models.UnitModel units = new Models.UnitModel(id, unit, note);
                return units.InsertUnit();
            }
            catch
            {
                return 0;
            }
        }
    }
}
