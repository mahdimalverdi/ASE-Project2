using Project2.Abstraction;
using Project2.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace Project2.Strategies
{
    public class JsonParser : IParserStrategy
    {
        public IEnumerable<Person> Parse(string text)
        {
            var result = JsonSerializer.Deserialize<IEnumerable<Person>>(text);
            return result;
        }
    }
}
