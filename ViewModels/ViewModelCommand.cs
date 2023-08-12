using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Diseno_Moderno_WPF.ViewModels
{
    public class ViewModelCommand : ICommand
    {
        private readonly Action<object> _executeAction;
        private readonly Predicate<object> _canExecute;

        public ViewModelCommand(Action<object> executeAction, Predicate<object> canExecute)
        {
            _executeAction = executeAction;
            _canExecute = canExecute;
        }

        public ViewModelCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
            _canExecute = null;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _executeAction(parameter);
        }
    }
}
