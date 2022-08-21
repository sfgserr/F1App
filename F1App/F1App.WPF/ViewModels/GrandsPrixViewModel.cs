using F1App.Models;
using System.Collections.Generic;

namespace F1App.WPF.ViewModels
{
    class GrandsPrixViewModel : ViewModelBase
    {
        public GrandsPrixViewModel() { }

        private List<GrandPrix> _grandsPrix;
        public List<GrandPrix> GrandsPrix 
        {
            get => _grandsPrix;
            set => Set(ref _grandsPrix, value);
        }
    }
}
