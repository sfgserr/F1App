using F1App.Models.Formatters;
using System.Threading.Tasks;

namespace F1App.Models.Parsers
{
    public class DriverParser : IDriverParser
    {
        private readonly IHtmlParser _parser;
        private readonly IFormatter _formatter;

        public DriverParser(IHtmlParser parser, IFormatter formatter)
        {
            _parser = parser;
            _formatter = formatter;
        }

        public async Task<string> ParseDriverName(string teamName, DriverRole driverRole)
        {
            int role = 0;

            switch (driverRole)
            {
                case DriverRole.FirstDriver:
                    role = 1;
                    break;
                case DriverRole.SecondDriver:
                    role = 2;
                    break;
            }
            _parser.Url = $"https://www.gpfans.com/en/f1-teams/{_formatter.Format(teamName, FormatType.Dash)}/";
            return await _parser.ParseSingle($"//*[@id='top-part']/div/div/div[2]/div[1]/table/tbody/tr[2]/td[1]/b/a[{role}]");
        }
        public async Task<string> ParseDriverName(int index)
        {
            _parser.Url = "https://en.wikipedia.org/wiki/List_of_Formula_One_drivers";
            return await _parser.ParseSingle($"//*[@id='mw-content-text']/div[1]/table[3]/tbody/tr[{index}]/td[1]/span/span/span/a");
        }
        public async Task<string> GetFlagPath(int index)
        {
            _parser.Url = "https://en.wikipedia.org/wiki/List_of_Formula_One_drivers";
            string nationality = await _parser.ParseSingle($"//*[@id='mw-content-text']/div[1]/table[3]/tbody/tr[{index}]/td[2]/text()");
           
            return $"/Resources/Images/Flags/{nationality}.png";
        }
    }
}
