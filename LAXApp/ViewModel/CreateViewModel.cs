using CommunityToolkit.Mvvm.ComponentModel;
using LAXApp.Commands;
using System.Windows;
using System.Windows.Input;

namespace LAXApp.ViewModel
{
    internal class CreateViewModel : ObservableObject
    {
        public ICommand CreateCommand { get; }

        public CreateViewModel()
        {
            CreateCommand = new CreateMovieCommand();
        }
    }
}
