using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LAXApp.Model;
using LAXApp.MSSQL;
using System.Collections.Generic;
using System.Windows;

namespace LAXApp.ViewModel
{
    internal partial class EditViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(MoviesList))]
        private List<Movie> movieList = new(BindGenresToCombobox.MoviesList());

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(GenresList))]
        private List<Genres> genreList = new(BindGenresToCombobox.GenresList());

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Movie))]
        private Movie? movieTitle;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Genre))]
        private Genres? movieGenre;

        public Movie? Movie => MovieTitle;
        public Genres? Genre => MovieGenre;
        public List<Movie> MoviesList => MovieList;
        public List<Genres> GenresList => GenreList;

        [RelayCommand]
        internal void EditMovieBtnClick()
        {
            if (Movie != null)
            {
                Movie? movie = Movie;

                Genres? genre = new();

                if (Genre != null) { genre.Type = Genre.Type; }
                else { genre.Type = "Ikke Angivet"; }

                foreach (Genres genreItem in GenresList)
                {
                    if (genre.Type == genreItem.Type)
                    {
                        genre = genreItem;
                        break;
                    }
                }

                EditMovie edit = new();
                edit.Edit_Movie(genre, movie);
            }
            else
            {
                MessageBox.Show("Vælg venligst Titel");
            }
        }

        [RelayCommand]
        internal void DeleteMovieBtnClick()
        {
            Movie? movie = new();

            if (Movie.Title != null)
            {
                foreach (Movie movieItem in MoviesList)
                {
                    if (Movie.Title == movieItem.Title)
                    {
                        movie = movieItem;
                        break;
                    }
                }
                EditMovie editMovie = new();
                editMovie.DeleteMovie(movie);
            }
            else { MessageBox.Show("Vælg venligst Film"); }
        }
    }
}
