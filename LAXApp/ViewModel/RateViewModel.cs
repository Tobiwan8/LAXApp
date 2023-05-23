using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LAXApp.Model;
using LAXApp.MSSQL;
using System.Collections.Generic;
using System.Windows;

namespace LAXApp.ViewModel
{
    internal partial class RateViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(MoviesList))]
        private List<Movie> movieList = new(BindGenresToCombobox.MoviesList());

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(RatingsList))]
        private int[] ratingList = new int[] {1,2,3,4,5};

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(ChosenMovie))]
        private Movie? movieTitle;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(ChosenRating))]
        private int? rating;

        public Movie? ChosenMovie => MovieTitle;
        public int? ChosenRating => Rating;
        public List<Movie> MoviesList => MovieList;
        public int[] RatingsList => RatingList;

        [RelayCommand]
        internal void RateMovieBtnClick()
        {
            if (ChosenMovie != null && ChosenRating != null)
            {
                Movie? movie = new();

                Ratings? rating = new() { Rating = (int)ChosenRating };

                foreach (Movie movieItem in MoviesList)
                {
                    if (movie.Title == movieItem.Title)
                    {
                        movie = movieItem;
                        break;
                    }
                }

                RateMovie rate = new();
                rate.Rate_Movie(rating, movie);
            }
            else
            {
                MessageBox.Show("Vælg venligst Titel og Rating");
            }
        }
    }
}
