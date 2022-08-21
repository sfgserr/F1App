using F1App.WPF.ViewModels;
using System;


namespace F1App.WPF.States.Navigators
{
    public enum ViewType
    {
        Drivers,
        Home,
        Winners,
        GrandsPrix
    }
    interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        event Action ViewModelChanged;
    }
}
