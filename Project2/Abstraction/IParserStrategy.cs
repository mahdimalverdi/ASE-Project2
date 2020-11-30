using Project2.Models;
using System.Collections.Generic;

namespace Project2.Abstraction
{
    public interface IParserStrategy
    {
        IEnumerable<Person> Parse(string text);
    }
}
