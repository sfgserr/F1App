using System.Collections.Generic;
using System.Threading.Tasks;

namespace F1App.Models.Builders.Interfaces
{
    public interface IDriverBuilder
    {
        Task<Driver> BuildDriver(int index);
    }
}
