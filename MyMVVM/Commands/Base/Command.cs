using System.Windows.Input;

namespace MyMVVM.Commands.Base
{
    /// <summary>
    /// Base class for all commands
    /// </summary>
    public abstract class Command : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public abstract bool CanExecute(object? parameter);

        public abstract void Execute(object? parameter);
    }
}
