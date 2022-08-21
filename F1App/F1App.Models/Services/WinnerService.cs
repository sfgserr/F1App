using System.Collections.Generic;
using System.Threading.Tasks;
using F1App.Models.Builders.Interfaces;
using F1App.Models.Services.Interfaces;

namespace F1App.Models.Services
{
    public class WinnerService : IWinnerService
    {
        private readonly IWinnerBuilder _winnerBuilder;

        public WinnerService(IWinnerBuilder winnerBuilder)
        {
            _winnerBuilder = winnerBuilder;
        }

        public async Task<List<Winner>> GetWinners()
        {
            List<Winner> winners = new List<Winner>();

            int firstYear = 1950;
            int lastYear = 2021;

            while (firstYear <= lastYear)
            {
                winners.Add(await _winnerBuilder.BuildWinner(firstYear));
                firstYear++;
            }

            return winners;
        }
    }
}
