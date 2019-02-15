using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf1
{
    public class ClassCommand : ICommand
    {
        private readonly Action actionToExecute;
        public ClassCommand(Action action)
        {
            actionToExecute = action;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
        public void Execute(object parameter)
        {
            actionToExecute();
        }
    }

    public class ClassCommandParameters : ICommand
    {
        private readonly Action<Object> actionToExecute;
        public ClassCommandParameters(Action<Object> action)
        {
            actionToExecute = action;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
        public void Execute(object parameter)
        {
            actionToExecute(parameter);
        }
    }

}