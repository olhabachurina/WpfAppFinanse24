using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppFinanse.Commands
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;
        public ICommand AddExpenseCommand { get; }
        // Конструктор для команд с параметрами
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
        }
        
        // Конструктор для команд без параметров
        public RelayCommand(Action executeNoParameter, Func<bool> canExecuteNoParameter = null)
        {
            if (executeNoParameter == null)
                throw new ArgumentNullException(nameof(executeNoParameter));

            // Обертываем Action и Func, чтобы они соответствовали ожидаемым делегатам
            this.execute = _ => executeNoParameter();
            this.canExecute = canExecuteNoParameter != null ? (Func<object, bool>)(_ => canExecuteNoParameter()) : (Func<object, bool>)null;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return canExecute?.Invoke(parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
        public void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }
}