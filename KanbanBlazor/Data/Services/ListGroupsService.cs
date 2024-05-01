using Microsoft.EntityFrameworkCore;
using KanbanBlazor.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace KanbanBlazor.Data.Services;

public class ListGroupsService
{
    private readonly IDbContextFactory<AppDbContext> _dbContextFactory;

    public ListGroupsService(IDbContextFactory<AppDbContext> dbContextFactory)
    {
        this._dbContextFactory = dbContextFactory;
    }

    public async Task<List<ListGroup>> GetAllListGroups()
    {
        using (var context = this._dbContextFactory.CreateDbContext())
        {
            return await context.Groups.ToListAsync();
        }
    }
}
