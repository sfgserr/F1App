using System.Windows.Media.Imaging;

namespace F1App.Models
{
    public class Driver : F1Entity
    {
        public string Name { get; set; }
        public Team Team { get; set; }
        public string FlagPath { get; set; }

        public override string ToString() => $"{Name}";
    }
}
