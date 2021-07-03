using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Controllers
{
    class UnitController
    {
        public static int InsertUnit(string _id, string _unit, string _note)
        {
            try
            {
                Models.UnitModel units = new Models.UnitModel(_id, _unit, _note);
                return units.InsertUnit();
            }
            catch
            {
                return 0;
            }
        }
    }
}
