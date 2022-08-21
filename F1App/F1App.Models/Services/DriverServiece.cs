using F1App.Models.Builders.Interfaces;
using F1App.Models.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1App.Models.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverBuilder _builder; 

        public DriverService(IDriverBuilder builder)
        {
            _builder = builder;
        }

        public List<Driver> Drivers { get; set; }

        public Driver GetDriverByName(string name)
        {
            return Drivers.FirstOrDefault(d => d.Name == name);
        }
        public async Task<List<Driver>> GetDriversAsync()
        {
            if (Drivers != null) return Drivers;
            Drivers = new List<Driver>();

            int startIndex = 2;
            int endIndex = 866;

            while (startIndex <= endIndex)
            {
                Drivers.Add(await _builder.BuildDriver(startIndex));
                startIndex++;
            }
            return Drivers;
        }
    }
}
