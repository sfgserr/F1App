using System;
using System.Windows.Input;

namespace F1App.WPF.Commands
{
    abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);
    }
}
