using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1App.WPF.States.Installers
{
    public enum EntityType
    {
        Driver,
        Winner,
        GrandPrix
    }
    public interface IInstaller
    {
        Task LoadAsync();
        bool IsLoading { get; set; }
        event Action IsLoadingChanged;
    }
}
