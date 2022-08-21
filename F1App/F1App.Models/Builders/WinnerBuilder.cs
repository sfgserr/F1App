using System.Threading.Tasks;
using F1App.Models.Parsers;
using F1App.Models.Services.Interfaces;
using F1App.Models.Builders.Interfaces;

namespace F1App.Models.Builders
{
    public class WinnerBuilder : IWinnerBuilder
    {
        private readonly IHtmlParser _parser;
        private readonly IDriverService _driverServiece;
        public WinnerBuilder(IHtmlParser parser, IDriverService driverServiece)
        {
            _parser = parser;
            _driverServiece = driverServiece;
        }

        public async Task<Winner> BuildWinner(int year)
        {
            _parser.Url = $"https://f1.fandom.com/wiki/{year}_Formula_One_Season";

            string driverName = await BuildDriverName();
            Driver driver = _driverServiece.GetDriverByName(driverName);

            return new Winner()
            {
                Driver = driver,
                Year = year
            };
        }
        private async Task<string> BuildDriverName() => await _parser.ParseSingle("//*[@id='mw-content-text']/div/aside/section[3]/div[1]/div/a");
    }
}
