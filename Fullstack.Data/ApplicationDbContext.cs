using Fullstack.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Fullstack.Data;

public class ApplicationDbContext : DbContext
{
    //private string? DbPath { get; }
    public DbSet<BlogPost> BlogPosts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=blog.db");
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
    {
        //Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
        //string path = Environment.GetFolderPath(folder);
        //DbPath = Path.Join(path, "Posts.db");
    }
}