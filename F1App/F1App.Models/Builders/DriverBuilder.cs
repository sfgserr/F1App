using System.Threading.Tasks;
using F1App.Models.Parsers;
using F1App.Models.Builders.Interfaces;

namespace F1App.Models.Builders
{
    public class DriverBuilder : IDriverBuilder
    {
        private readonly IDriverParser _driverParser;
        private readonly ITeamBuilder _teamBuilder;
        public DriverBuilder(IDriverParser driverParser, ITeamBuilder teamBuilder)
        {
            _teamBuilder = teamBuilder;
            _driverParser = driverParser;
        }
        public async Task<Driver> BuildDriver(int index)
        {
            #region crutch
            if (index == 291 || index == 301 || index == 815 || index == 824) index++;
            #endregion
            string name = await BuildName(index);
            Team team = await BuildTeam(name);
            string flagPath = await BuildFlagPath(index); 

            return new Driver() { Name = name, Team = team, FlagPath = flagPath };
        }
        private async Task<string> BuildName(int index) => await _driverParser.ParseDriverName(index);
        private async Task<Team> BuildTeam(string name) => await _teamBuilder.BuildTeam(name);
        private async Task<string> BuildFlagPath(int index) => await _driverParser.GetFlagPath(index);
    }
}
