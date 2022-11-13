namespace BlazorTodoApp.Models;

public class TodoItem
{
    [Key]
    public int TodoId { get; set; }
    public string Title { get; set; }
    public bool IsDone { get; set; }
}
