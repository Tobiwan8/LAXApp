using CommunityToolkit.Mvvm.ComponentModel;
using LAXApp.Commands;
using System.Windows;
using System.Windows.Input;

namespace LAXApp.ViewModel
{
    internal partial class CreateViewModel : ObservableObject
    {
        public ICommand CreateCommand { get; }

        public CreateViewModel()
        {
            CreateCommand = new CreateMovieCommand();
        }

        //Observable Properties
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(MovieInfo))]
        string movieTitle;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(MovieInfo))]
        string movieGenre;

        public string MovieInfo => $"{MovieTitle} {MovieGenre}";
    }
}
