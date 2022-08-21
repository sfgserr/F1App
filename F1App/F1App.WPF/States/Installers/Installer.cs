using F1App.Models.Services.Interfaces;
using F1App.WPF.ViewModels;
using System;
using System.Threading.Tasks;

namespace F1App.WPF.States.Installers
{
    class Installer : IInstaller
    {
        private readonly IDriverService _driverService;
        private readonly IWinnerService _winnerService;
        private readonly IGrandPrixService _grandPrixService;
        private readonly DriversViewModel _driversViewModel;
        private readonly WinnersViewModel _winnersViewModel;
        private readonly GrandsPrixViewModel _grandsPrixViewModel; 

        public Installer(IDriverService driverService, IWinnerService winnerService, IGrandPrixService grandPrixService, DriversViewModel drivers, WinnersViewModel winnersViewModel, GrandsPrixViewModel grandsPrixViewModel)
        {
            _driverService = driverService;
            _driversViewModel = drivers;
            _winnerService = winnerService;
            _winnersViewModel = winnersViewModel;
            _grandPrixService = grandPrixService;
            _grandsPrixViewModel = grandsPrixViewModel;
        }

        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set 
            { 
                _isLoading = value;
                IsLoadingChanged?.Invoke();
            }
        }

        public event Action IsLoadingChanged;

        public async Task LoadAsync()
        {
            IsLoading = true;

            await LoadDrivers();
            await LoadWinners();
            await LoadGrandsPrix();

            IsLoading = false;
        }
        private async Task LoadDrivers()
        {
           _driversViewModel.Drivers = await _driverService.GetDriversAsync();
        }
        private async Task LoadWinners()
        {
            _winnersViewModel.Winners = await _winnerService.GetWinners();
        }
        private async Task LoadGrandsPrix()
        {
            _grandsPrixViewModel.GrandsPrix = await _grandPrixService.GetGrandsPrix();
        }
    }
}
