﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LAXApp.Model;
using LAXApp.MSSQL;
using System.Collections.Generic;

namespace LAXApp.ViewModel
{
    internal partial class EditViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<string> movieList = new(BindGenresToCombobox.MoviesList());

        [ObservableProperty]
        private List<Genres> genreList = new(BindGenresToCombobox.GenresList());

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Title))]
        private string? movieTitle;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Genre))]
        private string? movieGenre;

        public string? Title => MovieTitle;
        public string? Genre => MovieGenre;

        [RelayCommand]
        void EditMovieBtnClick()
        {
            EditMovie.Edit_Movie(Title, Genre);
        }

        [RelayCommand]
        void DeleteMovieBtnClick()
        {
            EditMovie.DeleteMovie(Title);
            
        }
    }
}
