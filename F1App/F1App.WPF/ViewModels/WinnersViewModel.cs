using F1App.Models;
using System.Collections.Generic;

namespace F1App.WPF.ViewModels
{
    class WinnersViewModel : ViewModelBase
    {
        public WinnersViewModel() { }

        private List<Winner> _winners;
        public List<Winner> Winners
        {
            get => _winners; 
            set => Set(ref _winners, value);
        }

    }
}
