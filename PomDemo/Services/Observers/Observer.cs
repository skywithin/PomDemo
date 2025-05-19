namespace PomDemo.Services.Observers;

public class Observer
{
    protected Action? _listeners;

    public void Subscribe(Action? listener)
    {
        _listeners += listener;
    }

    public void Unsubscribe(Action? listener)
    {
        if (_listeners == null)
            return;

        _listeners -= listener;
    }

    public void Notify()
    {
        _listeners?.Invoke();
    }
}
