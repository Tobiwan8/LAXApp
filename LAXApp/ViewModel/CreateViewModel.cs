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
        [NotifyPropertyChangedFor(nameof(Title))]
        string? movieTitle;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Genre))]
        string? movieGenre;

        public string? Title => MovieTitle;
        public string? Genre => MovieGenre;

        [RelayCommand]
        void CreateMovieBtnClick()
        {
            MessageBox.Show(Title);
            //CreateMovie NewMovie = new();
            //NewMovie.AddMovie(MovieTitle, MovieGenre[]);
        }
    }
}
