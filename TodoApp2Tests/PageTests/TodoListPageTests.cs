using Microsoft.Playwright.Xunit;
using TodoApp2Tests.Models;

namespace TodoApp2Tests.PageTests;

public class TodoListPageTests : PageTest
{
    private const string BaseUrl = "https://localhost:7163";

    [Fact]
    public async Task AddTaskButton_ShouldAddNewTask()
    {
        // Arrange
        var page = new TodoListPage(Page, BaseUrl);
        
        await page.GotoAsync();

        var taskCountBefore = await page.GetTaskCountAsync();

        // Act: Click the "Add Task" button
        await page.ClickAddTaskBtnAsync();

        var taskCountAfter = await page.GetTaskCountAsync();

        // Assert: Verify that the task list count has increased (i.e., a new task was added)
        Assert.True(taskCountBefore < taskCountAfter, "New task should be added.");
    }
}
