using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.DatabaseContextDir;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options)
        : base(options)
    {
        
    }
    public DatabaseContext()
    {
        
    }
    public DbSet<Models.Task> Tasks { get; set; }
    public DbSet<Board> Boards { get; set; }
    public DbSet<TaskList> TaskLists { get; set; }
    public DbSet<User> Users { get; set; }
    
}