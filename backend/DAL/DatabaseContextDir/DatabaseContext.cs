using Microsoft.EntityFrameworkCore;

namespace DAL.DatabaseContextDir;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options)
        : base(options)
    {
        
    }
}