using System.Windows.Input;

namespace Applications.Desktop.AdminPanel.Commands;

public class ButtonCommand : ICommand
{
    private Action<object?> _execute;
    private Func<object?, bool> _canExecute;

    public ButtonCommand(Action<object?> execute, Func<object?, bool> canExecute = null)
    {
        _execute = execute;
        _canExecute = canExecute;
    }

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter)
    {
        return _canExecute == null || _canExecute.Invoke(parameter);
    }

    public void Execute(object? parameter)
    {
        _execute(parameter);
    }
}
