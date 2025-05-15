using Microsoft.AspNetCore.Components;
using PomDemo.Services;

namespace PomDemo.Components.Base;

/// <summary>
/// The base class for testable components that will automatically handle test IDs.
/// </summary>
public abstract class TestableComponentBase : ComponentBase
{
    /// <summary>
    /// The cascading TestIdProvider that handles the generation of hierarchical test IDs.
    /// </summary>
    [CascadingParameter]
    public TestIdProvider TestIdProvider { get; set; } = default!;

    /// <summary>
    /// The optional (custom) TestId parameter that allows manual specification of a test ID.
    /// </summary>
    [Parameter]
    public string? TestId { get; set; }

    /// <summary>
    /// The resolved test ID for this component after considering the parent hierarchy.
    /// </summary>
    public string ResolvedTestId { get; private set; } = default!;

    /// <summary>
    /// Called when component parameters are set to resolve and generate the final test ID.
    /// </summary>
    protected override void OnParametersSet()
    {
        var localId = TestId ?? GetType().Name.Replace("Component", "").ToLower();

        ResolvedTestId = TestIdProvider?.GetFullId(localId) ?? localId;
        TestIdProvider?.Push(localId);
    }

    /// <summary>
    /// Called after the component has rendered. Pops the component's local ID from the stack.
    /// </summary>
    protected override void OnAfterRender(bool firstRender)
    {
        TestIdProvider?.Pop();
    }
}
