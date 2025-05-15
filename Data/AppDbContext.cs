using Microsoft.EntityFrameworkCore;
using snipsvault.Models;

namespace snipsvault.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Snippet> Snippets { get; set; }
    }
}
// This code defines a DbContext class for an ASP.NET Core application using Entity Framework Core.
// The AppDbContext class inherits from DbContext and is used to interact with the database.