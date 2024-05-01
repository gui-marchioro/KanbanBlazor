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

	public async Task<List<Activity>> GetAllTasks()
	{
		using (var context = this._dbContextFactory.CreateDbContext())
		{
			return await context.Tasks.Include(t => t.ListGroup).ToListAsync();
		}
	}
	}
}
