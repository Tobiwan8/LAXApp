using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LAXApp.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand EditViewCommand { get; set; }
        public RelayCommand CreateViewCommand { get; set; }
        public RelayCommand RateViewCommand { get; set; }

        public CreateViewModel CreateVM { get; set; }
        public EditViewModel EditVM { get; set; }
        public RateViewModel RateVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView= value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            EditVM = new EditViewModel();
            RateVM = new RateViewModel();
            CreateVM = new CreateViewModel();

            EditViewCommand = new RelayCommand(() =>
            {
                CurrentView = EditVM;
            });

            CreateViewCommand = new RelayCommand(() =>
            {
                CurrentView = CreateVM;
            });

            RateViewCommand = new RelayCommand(() =>
            {
                CurrentView = RateVM;
            });
        }
    }
}
