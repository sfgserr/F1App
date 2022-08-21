using F1App.WPF.States.Navigators;
using F1App.WPF.ViewModels.Factories;
using F1App.WPF.ViewModels;


namespace F1App.WPF.Commands
{
    class UpdateViewCommand : Command
    {
        private readonly IFactoryViewModel _factory;
        private readonly INavigator _navigator;

        public UpdateViewCommand(IFactoryViewModel factory, INavigator navigator)
        {
            _factory = factory;
            _navigator = navigator;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            if(parameter is ViewType type)
            {
               _navigator.CurrentViewModel = _factory.CreateViewModel(type);
            }
        }
    }
}
