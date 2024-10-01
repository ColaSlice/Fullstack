using Fullstack.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Fullstack.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<BlogPost> BlogPosts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=blog.db");
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
    {
    }
}