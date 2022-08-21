using F1App.WPF.ViewModels;


namespace F1App.WPF.States.Navigators
{
    class Renavigator : IRenavigator
    {
        private readonly INavigator _navigator;

        public Renavigator(INavigator navigator)
        {
            _navigator = navigator;
        }

        public void Navigate(ViewModelBase viewModel)
        {
            _navigator.CurrentViewModel = viewModel;
        }
    }
}
