using Project2.Abstraction;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2.Strategies
{
    public class CsvParser : IParserStrategy
    {
        public IEnumerable<Person> Parse(string text)
        {
            var lines = text.Split("\n");

            var result = lines.Select(SplitLine).Select(GetPerson);

            return result;
        }

        private static string[] SplitLine(string l)
        {
            return l.Split(",");
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
