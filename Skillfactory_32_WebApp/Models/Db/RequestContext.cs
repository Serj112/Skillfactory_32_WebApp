using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Skillfactory_32_WebApp.Models.Db;

namespace Skillfactory_32_WebApp.Models.Db
{
    public sealed class RequestContext : DbContext
    {
        public DbSet<Request> DbRequests { get; set; }

        public RequestContext(DbContextOptions<RequestContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
