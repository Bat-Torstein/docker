using Shared;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WcfService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculationService), new Uri("http://localhost:7687")))
            {
                host.AddServiceEndpoint(typeof(ICalculation), new BasicHttpBinding(), "");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smb);
                //Start the Service
                host.Open();
                Console.WriteLine("Application Started");
                Console.ReadKey();
                host.Close();
                Console.WriteLine("Application Closed");
            }
        }
    }
}
