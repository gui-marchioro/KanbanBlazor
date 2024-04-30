using Microsoft.EntityFrameworkCore;
using KanbanBlazor.Models;

namespace KanbanBlazor.Data.Services;

public class TasksService
{
	private readonly AppDbContext _dbContext;

	public TasksService(AppDbContext dbContext)
	{
		this._dbContext = dbContext;
	}

	public async Task<List<Activity>> GetAllTasks()
	{
		return await _dbContext.Tasks.Include(t => t.ListGroup).ToListAsync();
	}
}
