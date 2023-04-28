using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LAXApp.Model;
using System.Collections.Generic;
using LAXApp.MSSQL;

namespace LAXApp.ViewModel
{
    internal partial class CreateViewModel : ObservableObject
    {
        //Observable Properties
        [ObservableProperty]
        Dictionary<string, int> movieGenres = new(Genres.MovieGenres);
        
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(MovieInfo))]
        string movieTitle;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(MovieInfo))]
        string? movieGenre;

        public string MovieInfo => $"{MovieTitle} {MovieGenre}";

        [RelayCommand]
        void CreateMovieBtnClick()
        {
            //MessageBox.Show(MovieInfo);
            CreateMovie NewMovie = new();
            NewMovie.AddMovie(MovieTitle, MovieGenre);
        }
    }
}
