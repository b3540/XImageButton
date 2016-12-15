using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XImageButton
{
    class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        private Action<object> _execute;

        public DelegateCommand(Action<object> exec) { _execute = exec; }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
