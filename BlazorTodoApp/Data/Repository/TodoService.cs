namespace BlazorTodoApp.Data.Repository;

public class TodoService : IRepository
{
    private readonly TodoContext _context;
    public TodoService(TodoContext context)
    {
        _context = context;
    }

    public void AddTodo(string todoName)
    {
        TodoItem newItem = new TodoItem()
        {
            Title = todoName,
            IsDone = false
        };

        _context.TodoItems.Add(newItem);
        _context.SaveChanges();
    }

    public void DeleteTodo(int id)
    {
        var todo = _context.TodoItems.Find(id);

        if (todo != null)
        {
            _context.TodoItems.Remove(todo);
            _context.SaveChanges();
        }
    }

    public IEnumerable<TodoItem> GetAllItems()
    {
        return _context.TodoItems;
    }

    public void ValueChanged(TodoItem changedItem)
    {
        var item = _context.TodoItems.Attach(changedItem);
        item.State = EntityState.Modified;

        _context.SaveChanges();
    }
}
