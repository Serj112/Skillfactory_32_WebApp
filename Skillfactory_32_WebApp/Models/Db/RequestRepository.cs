using Microsoft.EntityFrameworkCore;
using Skillfactory_32_WebApp.Models.Db;

namespace Skillfactory_32_WebApp.Models.Db
{
    public class RequestRepository : IRequestRepository
    {
        private RequestContext _context;
        public RequestRepository(RequestContext requestContext)
        {
            _context = requestContext;
        }
        public async Task AddRequest(Request request)
        {
            // Добавление пользователя
            var entry = _context.Entry(request);
            if (entry.State == EntityState.Detached)
                await _context.DbRequests.AddAsync(request);

            // Сохранение изенений
            await _context.SaveChangesAsync();
        }

        public async Task<Request[]> GetRequest()
        {
            return await _context.DbRequests.ToArrayAsync();
        }
    }
}
