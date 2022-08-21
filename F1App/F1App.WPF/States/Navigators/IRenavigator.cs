using F1App.WPF.ViewModels;

namespace F1App.WPF.States.Navigators
{
    interface IRenavigator
    {
        void Navigate(ViewModelBase viewModel);
    }
}
