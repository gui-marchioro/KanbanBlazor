using System.ComponentModel.DataAnnotations;

namespace KanbanBlazor.Models;

public class ListGroup
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "A name is required")]
    public string? Name { get; set; }
    public List<Activity>? Tasks { get; set; }
}
