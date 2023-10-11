
using Dashboard.Infrastructure.DataAccess.Contexts.Files.Configuration;
using Dashboard.Infrastructure.DataAccess.Contexts.Post.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Infrastructure.DataAccess
{
    /// <summary>
    /// Контекст БД.
    /// </summary>
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new FileConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
