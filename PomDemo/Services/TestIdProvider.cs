using System.Collections.Concurrent;

namespace PomDemo.Services;

/// <summary>
/// This class is responsible for generating and managing the data-test-id values
/// for Blazer components and ensuring that they follow a hierarchical structure.
/// </summary>
public class TestIdProvider
{
    private readonly ConcurrentStack<string> _testIdStack = new();

    /// <summary>
    /// Pushes the local component test ID onto the stack, creating a new scope.
    /// </summary>
    public void Push(string localId)
    {
        _testIdStack.Push(localId);
    }

    /// <summary>
    /// Pops the most recent test ID from the stack, ending the current scope.
    /// </summary>
    public void Pop()
    {
        _testIdStack.TryPop(out _);
    }

    /// <summary>
    /// Gets the full, hierarchical test ID, e.g. app.mainpage.loginform.submit
    /// </summary>
    public string GetFullId(string localId)
    {
        // Combine the component's local ID with its parent hierarchy.
        string parentHierarchy = string.Join(".", _testIdStack.ToArray().Reverse());

        return string.IsNullOrEmpty(parentHierarchy) ? localId : $"{parentHierarchy}.{localId}";
    }
}
