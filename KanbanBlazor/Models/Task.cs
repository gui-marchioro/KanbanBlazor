namespace KanbanBlazor.Models;

public class Task
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public TaskStatus? Status { get; set; }
    public int ListGroupId { get; set; }
    public virtual ListGroup? ListGroup { get; set; }
}
