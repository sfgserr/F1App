using System.Collections.Generic;
using System.Threading.Tasks;

namespace F1App.Models.Services.Interfaces
{
    public interface IDriverService
    {
       List<Driver> Drivers { get; set; }
       Driver GetDriverByName(string name);
       Task<List<Driver>> GetDriversAsync();
    }
}
