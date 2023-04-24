using LAXApp.ViewModel;
using System;
using System.Windows;
using System.Windows.Input;

namespace LAXApp.Repos.Commands
{
    internal class CloseAppCommand : ICommand
    {
        readonly ButtonCloseViewModel _buttonCloseViewModel;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return Application.Current != null && Application.Current.MainWindow != null;
        }

        public CloseAppCommand(ButtonCloseViewModel buttonCloseViewModel)
        {
            _buttonCloseViewModel = buttonCloseViewModel;
        }


        public void Execute(object? parameter)
        {
            _buttonCloseViewModel.OnExecute();
        }
    }
}
