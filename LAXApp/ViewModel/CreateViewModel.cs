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
        public readonly Dictionary<int, string> MovieGenres = new()
        {
            { 1, "Ikke Angivet" },
            { 2, "Action" },
            { 3, "Animated" },
            { 4, "Comedy" },
            { 5, "Drama" },
            { 6, "Horror" },
            { 7, "Romance" },
            { 8, "Sci-Fi" },
            { 9, "Thriller" }
        };

        //Observable Properties
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
