using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LAXApp.Model;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace LAXApp.ViewModel
{
    internal partial class CreateViewModel : ObservableObject
    {
        //Observable Properties
        [ObservableProperty]
        Dictionary<int, string> movieGenres = new(Genres.MovieGenres);
        
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(MovieInfo))]
        string? movieTitle;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(MovieInfo))]
        string? movieGenre;

        public string MovieInfo => $"{MovieTitle} {MovieGenre}";

        [RelayCommand]
        void CreateMovieBtnClick()
        {
            MessageBox.Show(MovieInfo);
        }
    }
}
