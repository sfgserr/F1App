using F1App.WPF.States.Navigators;
using System;

namespace F1App.WPF.ViewModels.Factories
{
    class FactoryViewModel : IFactoryViewModel
    {
        private readonly DriversViewModel _driver;
        private readonly HomeViewModel _home;
        private readonly WinnersViewModel _winner;
        private readonly GrandsPrixViewModel _grandsPrix;

        public FactoryViewModel(DriversViewModel driver, HomeViewModel home, WinnersViewModel winner, GrandsPrixViewModel grandsPrix)
        {
            _driver = driver;
            _home = home;
            _winner = winner;
            _grandsPrix = grandsPrix;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Home:
                    return _home;
                case ViewType.Drivers:
                    return _driver;
                case ViewType.Winners:
                    return _winner;
                case ViewType.GrandsPrix:
                    return _grandsPrix;
                default:
                    throw new ArgumentException("Such View Model doesn't exist");
            }
        }
    }
}
