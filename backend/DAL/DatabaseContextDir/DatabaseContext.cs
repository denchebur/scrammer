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


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Board>(entity =>
        {
            entity.HasOne(d => d.User).WithMany(p => p.Boards)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Boards_Users");
        });

        modelBuilder.Entity<Models.Task>(entity =>
        {
            entity.HasOne(d => d.TaskList).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.TaskListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tasks_TaskLists");
        });

        modelBuilder.Entity<TaskList>(entity =>
        {
            entity.HasOne(d => d.Board).WithMany(p => p.TaskLists)
                .HasForeignKey(d => d.BoardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaskLists_Boards");
        });

        
    }

    

}