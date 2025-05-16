namespace TodoApp2.Models;

public static class TodoItemsRepository
{
    private static List<TodoItem> Items =
        new()
        {
            TodoItem.Create(1, "Task 1"),
            TodoItem.Create(2, "Task 2"),
            TodoItem.Create(3, "Task 3"),
            TodoItem.Create(4, "Task 4"),
        };

    public static void AddItem(TodoItem item)
    {
        var maxId = Items.Any() ? Items.Max(s => s.Id) : 0;
        item.Id = maxId + 1;
        Items.Add(item);
    }

    public static List<TodoItem> GetItems() => Items;

    public static TodoItem? GetItemById(int id)
    {
        var item = Items.FirstOrDefault(s => s.Id == id);

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

    public static void UpdateItem(int id, TodoItem item)
    {
        if (id != item.Id)
            return;

        var itemToUpdate = Items.FirstOrDefault(s => s.Id == id);

        if (itemToUpdate != null)
        {
            itemToUpdate.IsCompleted = item.IsCompleted;
            itemToUpdate.Name = item.Name;
            itemToUpdate.CompletedAt = item.CompletedAt;
        }
    }

    public static void DeleteItem(int itemId)
    {
        var item = Items.FirstOrDefault(s => s.Id == itemId);

        if (item != null)
        {
            Items.Remove(item);
        }
    }

    public static List<TodoItem> SearchTodoItems(string filter)
    {
        return Items
                .Where(x => x.Name.Contains(filter, StringComparison.OrdinalIgnoreCase))
                .ToList();
    }
}
