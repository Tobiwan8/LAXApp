using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using LAXApp.MSSQL;
using LAXApp.Model;
using System.Windows;

namespace LAXApp.ViewModel
{
    internal partial class CreateViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(GenresList))]
        private List<Genres> genreList = BindGenresToCombobox.GenresList();

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Title))]
        private string? movieTitle;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Genre))]
        private Genres? movieGenre;

        public string? Title => MovieTitle;
        public Genres? Genre => MovieGenre;
        public List<Genres> GenresList => GenreList;

        [RelayCommand]
        internal void CreateMovieBtnClick()
        {
            if (Title != null)
            {
                Movie? movie = new()
                {
                    Title = Title
                };

                Genres? genre = new();
                if (Genre.Type == null) { Genre.Type = "Ikke Angivet"; }

                foreach (Genres genreItem in GenresList)
                {
                    if (Genre.Type == genreItem.Type)
                    {
                        genre = genreItem;
                        break;
                    }
                }

                CreateMovie create = new();
                create.AddMovie(genre, movie);
            }
            else
            {
                MessageBox.Show("Angiv venligst Titel");
            }
        }
    }
}
