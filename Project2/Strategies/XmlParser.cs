using Project2.Abstraction;
using Project2.Models;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Project2.Strategies
{
    public class XmlParser : IParserStrategy
    {
        public IEnumerable<Person> Parse(string text)
        {
            var document = XDocument.Parse(text);
            var serializer = new XmlSerializer(typeof(List<Person>));
            using var xmlReader = document.CreateReader();
            var result = serializer.Deserialize(xmlReader) as List<Person>;
            return result;
        }
    }
}
