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
        public static int DeleteService(string _idService)
        {
            try
            {
                Models.ServiceModel _service = new Models.ServiceModel(_idService);
                return _service.DeleteService();
            }
            catch
            {
                return 0;
            }
        }

        public static int InsertService(string _serviceID, string _serviceName, string _unitId, string _price, string _note)
        {
            try
            {
                Models.ServiceModel _service = new Models.ServiceModel(_serviceID, _serviceName, _unitId, _price, _note);
                return _service.InsertService();
            }
            catch
            {
                return 0;
            }
        }
    }
}
