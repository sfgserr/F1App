using System.Collections.Generic;
using System.Threading.Tasks;

namespace F1App.Models.Services.Interfaces
{
    public interface IWinnerService
    {
       Task<List<Winner>> GetWinners();
    }
}
