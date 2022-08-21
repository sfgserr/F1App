using HtmlAgilityPack;
using System.Threading.Tasks;

namespace F1App.Models.Parsers
{
    public class HtmlParser : IHtmlParser
    {
        private HtmlDocument _doc;
        private HtmlWeb _web = new HtmlWeb();
        public HtmlParser() { }
        
        private string _url;
        public string Url
        {
            get => _url;
            set
            {
                _url = value;
                _doc = _web.Load(_url);
            }
        }
        public async Task<string> ParseSingle(string xpath)
        {
            var data = await Parse(xpath);
            if (data != null) return data[0].InnerText.Trim();
            return " ";
        }
        public async Task<string> GetAttributeValue(string xpath, string attribute)
        {
            var data = await Parse(xpath);
            if(data != null) return data[0].Attributes[attribute].Value.Trim();
            return " ";
        }
        public async Task<HtmlNodeCollection> Parse(string xpath) => await Task.Run(() => _doc.DocumentNode.SelectNodes(xpath));
    }
}
