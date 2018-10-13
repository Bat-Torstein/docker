using System.ServiceModel;

namespace WcfClient
{
    public class ServiceFactory<T> where T : class
    {
        private T _service;

        public T GetService(string address)
        {
            return _service ?? (_service = GetServiceInstance(address));
        }

        private static T GetServiceInstance(string address)
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress(address);

            return ChannelFactory<T>.CreateChannel(binding, endpoint);
        }
    }
}
