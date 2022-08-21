using System.Threading.Tasks;

namespace F1App.Models.Builders.Interfaces
{
    public interface ITeamBuilder
    {
        Task<Team> BuildTeam(string driverName);
    }
}
