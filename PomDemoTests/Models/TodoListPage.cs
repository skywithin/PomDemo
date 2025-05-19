using Microsoft.Playwright;

namespace PomDemoTests.Models;

// Page object model for the Todo List page
public class TodoListPage
{
    private readonly IPage _page;

    // Locators
    private ILocator _btnAddTask => _page.Locator("[data-testid='2c8da3a6']");
    private ILocator _taskList => _page.Locator("ul.list-unstyled");

    // The URL of the Todo List page
    public string Url { get; }
    
    public TodoListPage(IPage page, string baseUrl)
    {
        _page = page;
        Url = $"{baseUrl}/todolist";
    }

    // Navigate to the Todo List page
    public async Task<TodoListPage> GotoAsync()
    {
        await _page.GotoAsync(Url);
        await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);  // Wait for the page to fully load
        return this;
    }

    // Click the "Add Task" button
    public async Task<TodoListPage> ClickAddTaskBtnAsync()
    {
        await _btnAddTask.ClickAsync();
        return this;
    }

    // Get the current count of tasks in the list
    public async Task<int> GetTaskCountAsync()
    {
        return await _taskList.Locator("li").CountAsync();  // Count the number of list items (tasks)
    }

}
