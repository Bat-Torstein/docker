using Shared;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading;

namespace WcfService
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (ServiceHost host = new ServiceHost(typeof(CalculationService), new Uri("http://localhost:7687")))
                {
                    host.AddServiceEndpoint(typeof(ICalculation), new BasicHttpBinding(), "");
                    ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                    smb.HttpGetEnabled = true;
                    host.Description.Behaviors.Add(smb);
                    host.Open();
                    Console.WriteLine("WCF Service Started");
                    while (true)
                    {
                        Thread.Sleep(10000);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
    }
}
