namespace TodoApp2.Models;

public class TodoItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    private bool _isCompleted;
    public bool IsCompleted 
    { 
        get => _isCompleted;
        set
        {
            _isCompleted = value;
            CompletedAt = value ? DateTime.UtcNow : null;
        }
    }

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
