using System.Threading.Tasks;

namespace F1App.Models.Builders.Interfaces
{
    public interface IGrandPrixBuilder
    {
        Task<GrandPrix> BuildGrandPrix(string grandPrixName);
    }
}
