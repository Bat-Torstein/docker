using Shared;
using System.Threading.Tasks;

namespace WcfService
{
    public class CalculationService : ICalculation
    {
        public Task<int> EvalvuateExpression(Expression express)
        {
            if (express.Operation == Operator.ADD)
            {
                return Task<int>.Run(() => express.FirstNumber + express.SecondNumber);
            }
            else
            {
                return Task<int>.Run(() => express.FirstNumber * express.SecondNumber);
            }
        }
    }
}