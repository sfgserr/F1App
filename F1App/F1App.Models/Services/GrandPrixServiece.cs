using System.Collections.Generic;
using System.Threading.Tasks;
using F1App.Models.Builders.Interfaces;
using F1App.Models.Services.Interfaces;

namespace F1App.Models.Services
{
    public class GrandPrixService : IGrandPrixService
    {
        private readonly IGrandPrixBuilder _grandPrixBuilder;

        public GrandPrixService(IGrandPrixBuilder grandPrixBuilder)
        {
            _grandPrixBuilder = grandPrixBuilder;
        }

        private string[] GrandPrixNames = { "Bahrain",
                                            "Saudi Arabian",
                                            "Australian",
                                            "Emilia Romagna",
                                            "Miami",
                                            "Spanish",
                                            "Monaco",
                                            "Azerbaijan",
                                            "Canadian",
                                            "British",
                                            "Austrian",
                                            "French",
                                            "Hungarian",
                                            "Belgium",
                                            "Dutch",
                                            "Italian",
                                            "Singapore",
                                            "Japanese",
                                            "United States",
                                            "Mexican",
                                            "Brazilian",
                                            "Abu Dhabi" };

        public async Task<List<GrandPrix>> GetGrandsPrix()
        {
            List<GrandPrix> grandsPrix = new List<GrandPrix>();
            foreach (string name in GrandPrixNames) grandsPrix.Add(await _grandPrixBuilder.BuildGrandPrix(name));
            return grandsPrix;
        }
    }
}
