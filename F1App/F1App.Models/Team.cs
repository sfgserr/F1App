
namespace F1App.Models
{
    public class Team : F1Entity
    {
        public string Name { get; set; }
        public Driver Driver1 { get; set; }
        public Driver Driver2 { get; set; }

        public override string ToString() => $"{Name}";
    }
}
