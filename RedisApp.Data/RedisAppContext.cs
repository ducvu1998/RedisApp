using Microsoft.EntityFrameworkCore;
using RedisApp.Data.Model;

namespace RedisApp.Data
{
    public class RedisAppContext : DbContext
    {
        public RedisAppContext(DbContextOptions<RedisAppContext> options)
            : base(options)
        {
        }
        public DbSet<ArticleMatrix> ArticleMatrices { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}