using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Controllers
{
    class ServiceController
    {

        // Method Delete
        public static int DeleteService(string idService)
        {
            try
            {
                Models.ServiceModel service = new Models.ServiceModel(idService);
                return service.DeleteService();
            }
            catch
            {
                return 0;
            }
        }

        public static int InsertService(string serviceID, string serviceName, string unitId, string price, string note)
        {
            try
            {
                Models.ServiceModel _service = new Models.ServiceModel(serviceID, serviceName, unitId, price, note);
                return _service.InsertService();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateService(string serviceID, string serviceName, string unitId, string price, string note)
        {
            try
            {
                Models.ServiceModel service = new Models.ServiceModel(serviceID, serviceName, unitId, price, note);
                return service.UpdateService();
            }
            catch
            {
                return 0;
            }
        }
    }
}
