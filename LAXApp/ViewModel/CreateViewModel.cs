using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Windows;
using System.Windows.Input;

namespace LAXApp.ViewModel
{
    internal partial class CreateViewModel : ObservableObject
    {
        //Observable Properties
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(MovieInfo))]
        string movieTitle;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(MovieInfo))]
        string movieGenre;

        public string MovieInfo => $"{MovieTitle} {MovieGenre}";

        [ObservableProperty]
        bool isBusy;

        public bool IsNotBusy => !IsBusy;

        [RelayCommand]
        void CreateMovieBtnClick()
        {
            IsBusy = true;

            MessageBox.Show(MovieInfo);

            IsBusy = false;
        }
    }
}
