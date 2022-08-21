using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace F1App.Models.Parsers
{
    public enum DriverRole
    {
        FirstDriver,
        SecondDriver
    }
    public interface IDriverParser
    {
        Task<string> ParseDriverName(string teamName, DriverRole driverRole);
        Task<string> ParseDriverName(int index);
        Task<string> GetFlagPath(int index);
    }
}
