﻿namespace KanbanBlazor.Models;

public class ListGroup
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<Task>? Tasks { get; set; }
}
