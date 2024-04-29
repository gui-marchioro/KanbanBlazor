using KanbanBlazor.Models.Enum;

namespace KanbanBlazor.Models;

public class Activity
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public ActivityStatus Status { get; set; }
    public int ListGroupId { get; set; }
    public virtual ListGroup? ListGroup { get; set; }
}
