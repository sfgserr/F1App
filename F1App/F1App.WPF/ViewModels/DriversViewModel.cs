using F1App.Models;
using System.Collections.Generic;

namespace F1App.WPF.ViewModels
{
    class DriversViewModel : ViewModelBase
    {
        public DriversViewModel() { }

        private List<Driver> _drivers;
        public List<Driver> Drivers 
        {
            get => _drivers;
            set => Set(ref _drivers, value);
        }
    }
}
