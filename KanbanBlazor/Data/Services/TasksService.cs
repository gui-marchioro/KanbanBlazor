using Microsoft.EntityFrameworkCore;
using KanbanBlazor.Models;

namespace KanbanBlazor.Data.Services;

public class TasksService
{
    private readonly IDbContextFactory<AppDbContext> _dbContextFactory;

    public TasksService(IDbContextFactory<AppDbContext> dbContextFactory)
    {
        this._dbContextFactory = dbContextFactory;
    }

    public async Task<List<Activity>>? GetAllTasks()
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync();
        return await context!.Tasks!.ToListAsync();
    }
}
