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

    public async Task<ListGroup> Add(ListGroup listGroup)
    {
        using (var context = this._dbContextFactory.CreateDbContext())
        {
            context.Groups.Add(listGroup);
            await context.SaveChangesAsync();
        }

        return listGroup;
    }

    public async Task<ListGroup> Delete(int id)
    {
        ListGroup? listGroup;
        using (var context = this._dbContextFactory.CreateDbContext())
        {
            listGroup = await context.Groups.FindAsync(id);
            context.Groups.Remove(listGroup);
            await context.SaveChangesAsync();
        }

        return listGroup;
    }

    public async Task<ListGroup> Update(ListGroup listGroup)
    {
        using (var context = this._dbContextFactory.CreateDbContext())
        {
            context.Entry(listGroup).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        return listGroup;
    }
}
