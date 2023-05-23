using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace LAXApp.ViewModel
{
    internal partial class MainWindowViewModel : ObservableObject
    {
        public CreateViewModel? CreateVM { get; set; }
        public EditViewModel? EditVM { get; set; }
        public RateViewModel? RateVM { get; set; }
        public OverviewViewModel? OverviewVM { get; set; }


        private object? _currentView;
        public object? CurrentView
        {
            get { if (_currentView != null) return _currentView; else { return null; } }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        [RelayCommand]
        internal void RateView()
        {
            RateVM = new RateViewModel();
            CurrentView = RateVM;
        }

        [RelayCommand]
        internal void EditView()
        {
            EditVM = new EditViewModel();
            CurrentView = EditVM;
        }

        [RelayCommand]
        internal void CreateView()
        {
            CreateVM = new CreateViewModel();
            CurrentView = CreateVM;
        }

        [RelayCommand]
        internal void OverviewView()
        {
            OverviewVM = new OverviewViewModel();
            CurrentView = OverviewVM;
        }
    }
}
