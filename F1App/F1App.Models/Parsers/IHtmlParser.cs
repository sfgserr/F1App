using HtmlAgilityPack;
using System.Threading.Tasks;

namespace F1App.Models.Parsers
{
    public interface IHtmlParser
    {
        string Url { get; set; }
        Task<HtmlNodeCollection> Parse(string xpath);
        Task<string> ParseSingle(string xpath);
        Task<string> GetAttributeValue(string xpath, string attribute);
    }
}
