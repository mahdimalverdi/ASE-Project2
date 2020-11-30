using Project2.Abstraction;
using Project2.Strategies;
using System;

namespace Project2
{
    public class ParserStrategyFactory
    {
        private const string Csv = "CSV";
        private const string Json = "JSON";
        private const string Xml = "XML";
        private readonly string type;

        public ParserStrategyFactory(string type)
        {
            this.type = type ?? throw new ArgumentNullException(nameof(type));
        }

        public IParserStrategy Create()
        {
            switch(type.ToUpperInvariant())
            {
                case Csv:
                    return new CsvParser();
                case Json:
                    return new JsonParser();
                case Xml:
                    return new XmlParser();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
