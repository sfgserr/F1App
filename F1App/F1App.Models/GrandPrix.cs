
namespace F1App.Models
{
    public class GrandPrix : F1Entity
    { 
        public string Name { get; set; }
        public string Length { get; set; }
        public Driver CurrentWinner { get; set; }
        public string BestCurrentLap { get; set; }
        public string MapPath { get; set; }
    }
}
