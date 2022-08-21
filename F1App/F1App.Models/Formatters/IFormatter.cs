
namespace F1App.Models.Formatters
{
    public enum FormatType
    {
        Dash,
        Space
    }
    public interface IFormatter
    {
        string Format(string s, FormatType format);
    }
}
