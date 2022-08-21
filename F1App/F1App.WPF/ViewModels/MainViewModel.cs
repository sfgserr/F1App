using F1App.WPF.Commands;
using F1App.WPF.States.Installers;
using F1App.WPF.States.Navigators;
using F1App.WPF.ViewModels.Factories;
using System.Windows.Input;

namespace F1App.WPF.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private readonly INavigator _navigator;
        private readonly IInstaller _installer;
        public MainViewModel(INavigator navigator, IFactoryViewModel factory, IInstaller installer)
        {
            _navigator = navigator;
            _navigator.ViewModelChanged += ViewModelChanged;
            _installer = installer;
            _installer.IsLoadingChanged += OnIsLoadingChanged;
            UpdateView = new UpdateViewCommand(factory, _navigator);
            UpdateView.Execute(ViewType.Home);
            LoadEntities = new LoadCommand(installer);
            LoadEntities.Execute(null);
        }
        public ViewModelBase CurrentView => _navigator.CurrentViewModel;
        public bool IsLoading => _installer.IsLoading;
        public ICommand UpdateView { get; }
        public ICommand LoadEntities { get; }

        private void ViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentView));
        }
        private void OnIsLoadingChanged()
        {
            OnPropertyChanged(nameof(IsLoading));
        }
    }
}
