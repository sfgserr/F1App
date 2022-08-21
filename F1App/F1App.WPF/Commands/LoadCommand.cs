using F1App.WPF.States.Installers;


namespace F1App.WPF.Commands
{
    class LoadCommand : Command
    {
        private readonly IInstaller _installer;

        public LoadCommand(IInstaller installer)
        {
            _installer = installer;
        }
        public override bool CanExecute(object parameter)
        {
            return true;
        }
        public override async void Execute(object parameter)
        {
            await _installer.LoadAsync();
        }
    }
}
