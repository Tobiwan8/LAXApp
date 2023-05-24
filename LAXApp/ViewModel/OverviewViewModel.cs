using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LAXApp.Model;
using LAXApp.MSSQL;
using System.Collections.Generic;

namespace LAXApp.ViewModel
{
    internal partial class OverviewViewModel : ObservableObject
    {
        //[ObservableProperty]
        //[NotifyPropertyChangedFor(nameof(MoviesList))]
        //private List<Movie> movieList = new(BindGenresToCombobox.MoviesList());
        //public List<Movie> MoviesList => MovieList;

        //public List<Movie> Movies = MoviesList;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(DGItemList))]
        private List<DataGridItem> dataGridItems = new(BindDataToDG.DGItemList());

        public List<DataGridItem> DGItemList => DataGridItems;
    }
}
