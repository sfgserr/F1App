using F1App.WPF.ViewModels;
using System;


namespace F1App.WPF.States.Navigators
{
    class Navigator : INavigator
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel?.Dispose();
                SetViewModel(ref _currentViewModel, value);
            }
        }

        public event Action ViewModelChanged;

        private bool SetViewModel<T>(ref T field, T value)
        {
            if (Equals(field, value)) return false;
            field = value;
            ViewModelChanged?.Invoke();
            return true;
        }
    }
}
