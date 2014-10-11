using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace App1.mvvm
{
    public class Command : ICommand
    {
        public Command(Action action)
        {
            this.action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
        private Action action;

        public void Execute(object parameter)
        {
            action();
        }
    }
}
