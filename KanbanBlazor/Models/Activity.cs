using KanbanBlazor.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KanbanBlazor.Models;

public class Activity
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Title required")]
    [StringLength(50, ErrorMessage = "Maximum length is 50 characters")]
    public string? Title { get; set; }

    [StringLength(200, ErrorMessage = "Maximum length is 200 characters")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Status required")]
    public ActivityStatus Status { get; set; }

    [Required(ErrorMessage = "Group required")]
    [ForeignKey(nameof(ListGroup))]
    public int? ListGroupId { get; set; }
    public virtual ListGroup? ListGroup { get; set; }
}
