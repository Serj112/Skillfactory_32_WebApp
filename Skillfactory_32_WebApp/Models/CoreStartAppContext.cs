using Microsoft.EntityFrameworkCore;

namespace Skillfactory_32_WebApp.Models
{
    public class CoreStartAppContext: DbContext
    {
        public DbSet<UserInfo> UserInfos { get; set; }

        public CoreStartAppContext(DbContextOptions<CoreStartAppContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserInfo>().ToTable("UserInfos");
        }
    }
}
