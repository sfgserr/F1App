using System.Threading.Tasks;
using F1App.Models.Services.Interfaces;
using F1App.Models.Builders.Interfaces;

namespace F1App.Models.Builders
{
    public class TeamBuilder : ITeamBuilder
    {
        private readonly ITeamService _teamServiece;

        public TeamBuilder(ITeamService teamServiece)
        {
            _teamServiece = teamServiece;
        }

        private Team _team;

        public async Task<Team> BuildTeam(string driverName)
        {
            string teamName = await BuildTeamName(driverName);
            if (teamName == " ") return new Team();

            (string driver1Name, string driver2Name) = await BuildDriversName(teamName);

            _team = new Team()
            {
                Name = teamName,
                Driver1 = new Driver() { Name = driver1Name, Team = _team },
                Driver2 = new Driver() { Name = driver2Name, Team = _team },
            };

            return _team;
        }
        private async Task<string> BuildTeamName(string driverName) => await _teamServiece.GetTeamName(driverName);
        private async Task<(string, string)> BuildDriversName(string teamName) => await _teamServiece.GetDriversName(teamName); 
    }
}
