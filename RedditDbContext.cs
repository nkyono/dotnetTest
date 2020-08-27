using System;
using Microsoft.EntityFrameworkCore;
namespace testApp
{
    public class RedditDbContext : DbContext
    {
        // public RedditDbContext(DbContextOptions<RedditDbContext> options) : base(options) { }

        public DbSet<RedditPost> Reddit_Posts { get; set; }

        // https://www.npgsql.org/efcore/index.html
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=LocalDB;Username=nick");
    }
}
