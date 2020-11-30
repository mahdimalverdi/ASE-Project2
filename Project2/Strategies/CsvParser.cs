using Project2.Abstraction;
using Project2.Models;
using System.Collections.Generic;
using System.Linq;

namespace Project2.Strategies
{
    public class CsvParser : IParserStrategy
    {
        private const string LineSeparator = "\n";
        private const string CellSeparator = ",";

        public IEnumerable<Person> Parse(string text)
        {
            var lines = text.Split(LineSeparator);
            var result = lines.Select(SplitLine).Select(GetPerson);
            return result;
        }

        private static string[] SplitLine(string l)
        {
            return l.Split(CellSeparator);
        }

        private static Person GetPerson(string[] l)
        {
            return new Person()
            {
                Age = int.Parse(l[2]),
                FirstName = l[0],
                LastName = l[1]
            };
        }
    }
}
