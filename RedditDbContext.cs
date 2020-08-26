using System;
using Microsoft.EntityFrameworkCore;
namespace testApp
{
    public class RedditDbContext : DbContext
    {
        public RedditDbContext(DbContextOptions<RedditDbContext> options) { }
        public DbSet<RedditPost> Posts { get; set; }
        // TODO: want to change so that config is in environment, but currently don't want to look it up
        // and there are no "secrets"
        // https://www.npgsql.org/efcore/index.html
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=LocalDB;Username=nick");
    }
}
