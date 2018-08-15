using System.Threading.Tasks;

namespace EnvironmentDotNet.Core.Networking
{
    public interface INetworkService
    {
        Task<T> GetJson<T>(string uri);
        Task<TOut> PostJson<TIn, TOut>(string uri, TIn content);
    }
}