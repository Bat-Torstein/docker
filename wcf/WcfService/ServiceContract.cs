using System.ServiceModel;
using System.Threading.Tasks;

namespace Shared
{
    [ServiceContract]
    public interface ICalculation
    {
        [OperationContract]
        Task<int> EvalvuateExpression(Expression express);
    }
}
