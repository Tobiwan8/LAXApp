using CommunityToolkit.Mvvm.ComponentModel;
using LAXApp.Model;
using LAXApp.MSSQL;
using System.Collections.Generic;

namespace LAXApp.ViewModel
{
    internal partial class RateViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(MoviesList))]
        private List<Movie> movieList = new(BindGenresToCombobox.MoviesList());

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(RatingsList))]
        private List<Ratings> ratingList = new();

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(ChosenMovie))]
        private Movie? movieTitle;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(ChosenRating))]
        private Ratings? rating;

        public Movie? ChosenMovie => MovieTitle;
        public Ratings? ChosenRating => Rating;
        public List<Movie> MoviesList => MovieList;
        public List<Ratings> RatingsList => RatingList;
    }
}
