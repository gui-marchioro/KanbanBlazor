using KanbanBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace KanbanBlazor.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<ListGroup> Groups { get; set; }
    public DbSet<Activity> Tasks { get; set; }
}
