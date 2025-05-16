namespace TodoApp2.Models;

public static class TodoItemsRepository
{
    private static List<TodoItem> todoItems =
        new()
        {
            TodoItem.Create(1, "Task 1"),
            TodoItem.Create(2, "Task 2"),
            TodoItem.Create(3, "Task 3"),
            TodoItem.Create(4, "Task 4"),
        };

    public static void AddItem(TodoItem todoItem)
    {
        var maxId = todoItems.Any() ? todoItems.Max(s => s.Id) : 0;
        todoItem.Id = maxId + 1;
        todoItems.Add(todoItem);
    }

    public static List<TodoItem> GetItems() => todoItems;

    public static TodoItem? GetItemById(int id)
    {
        var item = todoItems.FirstOrDefault(s => s.Id == id);

        if (item != null)
        {
            return new TodoItem
            {
                Id = item.Id,
                Name = item.Name,
                IsCompleted = item.IsCompleted,
                CompletedAt = item.CompletedAt
            };
        }

        return null;
    }

    public static void UpdateItem(int id, TodoItem todoItem)
    {
        if (id != todoItem.Id)
            return;

        var serverToUpdate = todoItems.FirstOrDefault(s => s.Id == id);

        if (serverToUpdate != null)
        {
            serverToUpdate.IsCompleted = todoItem.IsCompleted;
            serverToUpdate.Name = todoItem.Name;
            serverToUpdate.CompletedAt = todoItem.CompletedAt;
        }
    }

    public static void DeleteItem(int todoItemId)
    {
        var todoItem = todoItems.FirstOrDefault(s => s.Id == todoItemId);

        if (todoItem != null)
        {
            todoItems.Remove(todoItem);
        }
    }

    public static List<TodoItem> SearchTodoItems(string filter)
    {
        return todoItems
                .Where(x => x.Name.Contains(filter, StringComparison.OrdinalIgnoreCase))
                .ToList();
    }
}
