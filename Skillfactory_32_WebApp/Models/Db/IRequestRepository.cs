using Azure.Core;
using Skillfactory_32_WebApp.Models.Db;

namespace Skillfactory_32_WebApp.Models.Db
{
    public interface IRequestRepository
    {
        Task AddRequest(Request request);
        Task<Request[]> GetRequest();
    }
}
