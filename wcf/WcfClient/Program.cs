using Shared;
using System;
using System.Threading.Tasks;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doing some calculations:");
            ServiceFactory<ICalculation> serviceFactory = new ServiceFactory<ICalculation>();
            ICalculation service = serviceFactory.GetService("http://localhost:7687");
            Task<int> t = service.EvalvuateExpression(new Expression() { FirstNumber = 1, SecondNumber = 1, Operation = Operator.ADD });
            t.Wait();
            Console.WriteLine($" 2 + 2 is {t.Result}");
            Task<int> t2 = service.EvalvuateExpression(new Expression() { FirstNumber = 7, SecondNumber = 6, Operation = Operator.MULTIPLY });
            t2.Wait();
            Console.WriteLine($" 7 * 6 is {t2.Result}");
        }
    }
}
