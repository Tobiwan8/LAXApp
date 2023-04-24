using LAXApp.Repos.Commands;
using System.Windows;

namespace LAXApp.ViewModel
{
    internal class ButtonCloseViewModel
    {
        public CloseAppCommand CloseAppCommand { get; set; }
        public ButtonCloseViewModel()
        {
            CloseAppCommand = new CloseAppCommand(this);
        }

        public void OnExecute()
        {
            Application.Current.MainWindow.Close();
        }
    }
}
