using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LAXApp.Model;
using System.Collections.Generic;
using LAXApp.MSSQL;
using System.Windows;

namespace LAXApp.ViewModel
{
    internal partial class CreateViewModel : ObservableObject
    {
        //Observable Properties
        [ObservableProperty]
        private List<string> genreList = new(BindGenresToCombobox.GenresList());

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Title))]
        private string? movieTitle;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Genre))]
        private string? movieGenre;

        public string? Title => MovieTitle;
        public string? Genre => MovieGenre;

        [RelayCommand]
        void CreateMovieBtnClick()
        {
            CreateMovie.AddMovie(MovieTitle, MovieGenre);
        }
    }
}
