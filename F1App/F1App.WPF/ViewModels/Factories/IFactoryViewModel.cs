using F1App.WPF.States.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1App.WPF.ViewModels.Factories
{
    interface IFactoryViewModel
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}
