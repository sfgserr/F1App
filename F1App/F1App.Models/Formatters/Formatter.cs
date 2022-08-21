using System;

namespace F1App.Models.Formatters
{
    public class Formatter : IFormatter
    {
        public string Format(string s, FormatType format)
        {
            switch (format)
            {
                case FormatType.Dash:
                    return s.ToLower().Replace(' ', '-');
                case FormatType.Space:
                    return s.Replace(' ', '_');
                default:
                    throw new ArgumentException("Such Format Type doesn't exist");
            }
        }
    }
}
