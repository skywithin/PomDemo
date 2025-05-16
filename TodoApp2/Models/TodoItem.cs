namespace TodoApp2.Models;

public class TodoItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
    public DateTime? CompletedAt { get; set; }

    public static TodoItem Create(int id, string name)
    {
        return new TodoItem
        {
            Id = id,
            Name = name,
            IsCompleted = false,
        };
    }
}
