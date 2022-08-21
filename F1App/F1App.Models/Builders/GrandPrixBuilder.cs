using System.Threading.Tasks;
using F1App.Models.Services.Interfaces;
using F1App.Models.Builders.Interfaces;
using F1App.Models.Formatters;
using F1App.Models.Parsers;

namespace F1App.Models.Builders
{
    public class GrandPrixBuilder : IGrandPrixBuilder
    {
        private readonly IFormatter _formatter;
        private readonly IHtmlParser _parser;
        private readonly IDriverService _driverService;

        public GrandPrixBuilder(IFormatter formatter, IHtmlParser parser, IDriverService driverService)
        {
            _formatter = formatter;
            _parser = parser;
            _driverService = driverService;
        }

        public async Task<GrandPrix> BuildGrandPrix(string grandPrixName)
        {
            string length = await BuildCircuitLength(grandPrixName);
            Driver driver = await BuildCurrentWinner(grandPrixName);
            string bestCurrentLap = await BuildBestCurrentLap(grandPrixName);
            string mapPath = $"/Resources/Images/Maps/{grandPrixName}.png";

            return new GrandPrix()
            {
                Name = grandPrixName,
                Length = length,
                CurrentWinner = driver,
                BestCurrentLap = bestCurrentLap,
                MapPath = mapPath
            };
        }
        private async Task<string> BuildBestCurrentLap(string grandPrixName)
        {
            SetUrl(grandPrixName);
            return await _parser.ParseSingle("//*[@id='mw-content-text']/div[1]/table[1]/tbody/tr[17]/td/div/ul/li[3]");
        }
        private async Task<string> BuildCircuitLength(string grandPrixName)
        {
            SetUrl(grandPrixName);
            return await _parser.ParseSingle("//*[@id='mw-content-text']/div[1]/table[1]/tbody/tr[8]/td/text()[1]");
        }
        private async Task<Driver> BuildCurrentWinner(string grandPrixName)
        {
            SetUrl(grandPrixName);

            string driverName = await _parser.GetAttributeValue("//*[@id='mw-content-text']/div[1]/table[1]/tbody/tr[15]/td/div/ul/li[1]/div/ul/li[1]/a", "title");
            return _driverService.GetDriverByName(driverName);
        }
        private void SetUrl(string grandPrixName)
        {
            _parser.Url = $"https://en.wikipedia.org/wiki/{_formatter.Format(grandPrixName, FormatType.Space)}_Grand_Prix";
        }
    }
}
