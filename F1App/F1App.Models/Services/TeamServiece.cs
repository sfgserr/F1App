using F1App.Models.Parsers;
using F1App.Models.Services.Interfaces;
using F1App.Models.Formatters;
using System.Threading.Tasks;

namespace F1App.Models.Services
{
    public class TeamService : ITeamService
    {
        private readonly IHtmlParser _parser;
        private readonly IFormatter _formatter;
        private readonly IDriverParser _driverParser;

        public TeamService(IHtmlParser parser, IFormatter formatter, IDriverParser driverParser)
        {
            _parser = parser;
            _formatter = formatter;
            _driverParser = driverParser;
        }

        public async Task<(string, string)> GetDriversName(string teamName) =>
                   (await _driverParser.ParseDriverName(teamName, DriverRole.FirstDriver),
                    await _driverParser.ParseDriverName(teamName, DriverRole.SecondDriver));

        public async Task<string> GetTeamName(string driverName)
        {
            _parser.Url = $"https://www.gpfans.com/en/f1-drivers/{_formatter.Format(driverName, FormatType.Dash)}/";
            return await _parser.ParseSingle("//*[@id='center-part']/div/div/div[1]/div[3]/div[1]/div[2]/span/a");
        }
    }
}
