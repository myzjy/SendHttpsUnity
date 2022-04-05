using GameSystem.ServiceDataStruct;

namespace GameSystem.ServiceDataPro
{
    public class MasterUserPro : BaseServiceData
    {
        private MasterServiceDataPro service_data = null;

        internal MasterServiceDataPro ser_serviceData
        {
            set { service_data = value; }
        }

        protected IBaseDataTypeFinder BaseDataTypeFinder
        {
            get { return service_data; }
        }
    }
}