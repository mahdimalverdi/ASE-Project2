using Project2.Abstraction;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    internal class CommandReader : ICommandReader
    {
        private const string EndOfFile = "EOF";
        private const string EndLine = "\n";

        public Command Read()
        {
            var type = Console.ReadLine();
            var lines = GetLines();
            var text = string.Join(EndLine, lines);

            return new Command(type, text);
        }

        private static IEnumerable<string> GetLines()
        {
            string newLine;
            while (!(newLine = Console.ReadLine()).ToUpperInvariant().Equals(EndOfFile))
            {
                yield return newLine;
            }
        }
    }
}
