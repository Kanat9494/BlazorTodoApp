namespace BlazorTodoApp.Data.Repository
{
    public interface IRepository
    {
        IEnumerable<TodoItem> GetAllItems();

        void AddTodo(string todoName);

        void ValueChanged(TodoItem changedItem);

        void DeleteTodo(int id);
    }
}
