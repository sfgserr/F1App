using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1App.Models.Services.Interfaces
{
    public interface ITeamService
    {
        Task<(string, string)> GetDriversName(string teamName);
        Task<string> GetTeamName(string driverName);
    }
}
