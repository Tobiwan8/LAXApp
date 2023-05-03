using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using LAXApp.MSSQL;
using LAXApp.Model;
using System.Linq;

namespace LAXApp.ViewModel
{
    internal partial class CreateViewModel : ObservableObject
    {
        //Observable Properties
        [ObservableProperty]
        private List<Genres> genreList = BindGenresToCombobox.GenresList();

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Title))]
        private string? movieTitle;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Genre))]
        private string? movieGenre;

        public string? Title => MovieTitle;
        public string? Genre => MovieGenre;

        [RelayCommand]
        internal void CreateMovieBtnClick()
        {
            _createMovie?.AddMovie(genreList?.FirstOrDefault(o => o.Type == Genre), new Movie());

        }

        private readonly CreateMovie? _createMovie = null;

        public CreateViewModel()
        {
            genreList = new(BindGenresToCombobox.GenresList());
            _createMovie = new CreateMovie();
        }
    }
}
