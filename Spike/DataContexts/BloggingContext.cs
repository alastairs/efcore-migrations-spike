using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Spike.Models;

namespace Spike.DataContexts
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = new SqlConnectionStringBuilder
            {
                DataSource = @"(localdb)\mssqllocaldb",
                InitialCatalog = "Blogs"
            }.ToString();
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
